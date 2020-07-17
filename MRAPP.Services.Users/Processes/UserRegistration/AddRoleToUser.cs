namespace MRAPP.Services.Users.Processes.UserRegistration
{
    using MRAPP.Insfrastructure.Messages.UserRegistration;
    using MRAPP.Insfrastructure.Processes;
    using MRAPP.Services.Users.Enums;
    using System.Threading.Tasks;

    public class AddRoleToUser : ProcessStep<UserRegistrationResponse>
    {
        private readonly UserRegistrationContext userRegistrationContext;

        public AddRoleToUser(UserRegistrationContext userRegistrationContext)
        {
            this.userRegistrationContext = userRegistrationContext;
        }


        public override async Task ProcessAsync()
        {
            var userManager = userRegistrationContext.UserManager;
            var request = userRegistrationContext.Request;
            var user = await userRegistrationContext.UserManager.FindByEmailAsync(request.Email);

            var identityResult = await userManager.AddToRoleAsync(user, request.Role);

            if (identityResult.Succeeded)
            {
                if (this.Next != null)
                    await this.Next.ProcessAsync();
            }
            else
            {
                userRegistrationContext.Result.SetError((int)StatusCodes.AddRoleFailed);
            }

        }

    }
}
