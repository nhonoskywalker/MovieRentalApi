namespace MRAPP.Services.Users.Processes.UserRegistration
{
    using MRAPP.Data.Entities.Users;
    using MRAPP.Insfrastructure.Messages.UserRegistration;
    using MRAPP.Insfrastructure.Processes;
    using MRAPP.Services.Users.Enums;
    using System.Threading.Tasks;

    public class CreateUser : ProcessStep<UserRegistrationResponse>
    {
        private readonly UserRegistrationContext userRegistrationContext;

        public CreateUser(UserRegistrationContext userRegistrationContext)
        {
            this.userRegistrationContext = userRegistrationContext;
        }

        public override async Task ProcessAsync()
        {
            var request = userRegistrationContext.Request;
            var user = await userRegistrationContext.UserManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                var entity = new UserEntity {
                    UserName = request.Username,
                    Email = request.Email,
                    Fullname = request.Fullname
                };

                var identityResult = await userRegistrationContext.UserManager.CreateAsync(entity, request.Password);

                if (identityResult.Succeeded)
                {
                    await this.Next?.ProcessAsync();
                }
                else
                {
                    userRegistrationContext.Result.SetError((int)StatusCodes.RegistrationFailed);
                }
            }
            else
            {
                userRegistrationContext.Result.SetError((int)StatusCodes.UserAlreadyExists);
            }
        }

    }
}
