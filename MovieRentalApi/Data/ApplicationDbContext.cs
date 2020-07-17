namespace MRAPP.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using MRAPP.Data.Entities.Users;
    using MRAPP.Data.Movies;
    using MRAPP.Infrastructure.Data;
    using System;
    using System.Threading.Tasks;
    public class ApplicationDbContext : IdentityDbContext<
        UserEntity, RoleEntity, Guid, UserClaimEntity, UserRolesEntity, UserLoginEntity, RoleClaimEntity, UserTokenEntity>,
        IApplicationDbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<MovieEntity> Movies { get; set; }

        public override DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserEntity>(entity =>
            {
                entity.ToTable(name: "Users");
            });

            builder.Entity<RoleEntity>(entity =>
            {
                entity.ToTable(name: "Roles");
            });

            builder.Entity<UserRolesEntity>(entity =>
            {
                entity.ToTable(name: "UserRoles");
            });

            builder.Entity<UserClaimEntity>(entity =>
            {
                entity.ToTable(name: "UserClaims");
            });

            builder.Entity<RoleClaimEntity>(entity =>
            {
                entity.ToTable(name: "RoleClaims");
            });

            builder.Entity<UserLoginEntity>(entity =>
            {
                entity.ToTable(name: "UserLogins");
            });

            builder.Entity<UserTokenEntity>(entity =>
            {
                entity.ToTable(name: "UserTokens");
            });

            builder.Entity<MovieEntity>(entity =>
            {
                entity.ToTable("Movies");
                entity.HasKey(c => c.Id);
            });
        }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
