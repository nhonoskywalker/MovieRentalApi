namespace MRAPP.Services.Authentication.Processes.LogIn
{
    using MRAPP.Data.Entities.Users;
    using MRAPP.Insfrastructure.Messages.LogIn;
    using MRAPP.Insfrastructure.Processes;
    using MRAPP.Services.Authentication.Processes.Enums;
    using MRAPP.Services.AuthToken;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    public class LogInContext : ProcessContext<LogInResponse>
    {
        public LogInContext(LogInRequest request, ITokenService tokenService, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
        {
            this.Result = new LogInResponse();
            this.Request = request;
            this.UserManager = userManager;
            this.SignInManager = signInManager;
            this.TokenService = tokenService;
        }

     

        public LogInRequest Request { get; private set; }

        public UserManager<UserEntity> UserManager { get; private set; }

        public SignInManager<UserEntity> SignInManager { get; private set; }

        public ITokenService TokenService { get; private set; }

        public override async Task<LogInResponse> ProcessAsync()
        {
            this.Result.StatusCode = (int)StatusCodes.LogInSuccess;

            var logIn = new LogIn(this);
            logIn.SetNext(new CreateUserToken(this));

            await logIn.ProcessAsync();
          
            return this.Result;
        }
    }
}
