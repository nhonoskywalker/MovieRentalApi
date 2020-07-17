namespace MRAPP.Services.Authentication.Processes.LogIn
{
    using MRAPP.Insfrastructure.Messages.LogIn;
    using MRAPP.Insfrastructure.Processes;
    using MRAPP.Services.Authentication.Processes.Enums;
    using System.Threading.Tasks;

    public class LogIn : ProcessStep<LogInResponse>
    {
        private readonly LogInContext logInContext;

        public LogIn(LogInContext logInContext)
        {
            this.logInContext = logInContext;
        }


        public override async Task ProcessAsync()
        {
            var request = logInContext.Request;
            var user = await logInContext.UserManager.FindByEmailAsync(request.Email);

            var signInResult = await logInContext.SignInManager.PasswordSignInAsync(user.UserName, request.Password, false, false);


            if (signInResult.Succeeded)
            {
                if (this.Next != null)
                    await this.Next.ProcessAsync();
            }
            else
            {
                logInContext.Result.SetError((int)StatusCodes.LogInFailed);
            }
        }

    }
}
