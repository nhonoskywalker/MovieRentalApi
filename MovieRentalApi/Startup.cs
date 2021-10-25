using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MRAPP.Data;
using MRAPP.Data.Entities.Users;
using MRAPP.Infrastructure.Data;
using MRAPP.Insfrastructure.Providers;
using MRAPP.Options;
using MRAPP.Providers;
using MRAPP.Services.Authentication;
using MRAPP.Services.AuthToken;
using MRAPP.Services.Movies;
using MRAPP.Services.Movies.Repository;
using MRAPP.Services.Roles;
using MRAPP.Services.Users;
using MRAPP.Services.Users.Repository;
using System.Text;

namespace MovieRentalApi
{

    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();

            services.AddSingleton<IDbConnectionStringProvider, DbConnectionStringProvider>();

            var connectionString = this.Configuration.GetSection("DbConnectionString").Get<DbConnectionString>();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString.Database)
            .EnableSensitiveDataLogging(Configuration.GetValue<bool>("Logging:EnableSqlParameterLogging")));


            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<IMoviesRepository, MoviesRepository>();
            services.AddScoped<IMovieService, MovieService>();

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddScoped<ITokenService, TokenService>();

            this.ConfigureIdentity(services);
            this.Seed(services);
            this.ConfigureAuth(services);

			services.AddSwaggerGen(swagger =>
			{
				swagger.SwaggerDoc("v2", new OpenApiInfo
				{
					Title = "Practice API",
					Version = "v2",
					Description = "API to unerstand request and response schema.",
				});
			});
		}

        public void Seed(IServiceCollection services)
        {
            var roleManager = services.BuildServiceProvider().GetService<RoleManager<RoleEntity>>();

            RoleService.CreateRolesAsync(roleManager).ConfigureAwait(false);
        }

        public void ConfigureAuth(IServiceCollection services)
        {
            services.AddScoped<IJwtOptionsProvider, JwtOptionsProvider>();
            services.Configure<JwtSettings>(this.Configuration.GetSection("JwtSettings"));

            var jwtOptionsProvider = services.BuildServiceProvider().GetService<IJwtOptionsProvider>();

            var jwt = jwtOptionsProvider.GetJwtOptions();

            var key = Encoding.ASCII.GetBytes(jwt.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }

        public void ConfigureIdentity(IServiceCollection services)
        {
            services.AddIdentity<UserEntity, RoleEntity>()
             .AddEntityFrameworkStores<ApplicationDbContext>()
             .AddDefaultTokenProviders()
             .AddRoles<RoleEntity>();

            services.Configure<IdentityOptions>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 0;

                // User settings.
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
			app.UseSwagger();
			app.UseSwagger();
			app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v2/swagger.json", "PlaceInfo Services"));
			app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
