namespace MRAPP.Services.Users
{
    using MRAPP.Insfrastructure.Messages.UserRegistration;
    using System.Threading.Tasks;

    public interface IUserService
    {
        Task<UserRegistrationResponse> RegisterUserAsync(UserRegistrationRequest request);
    }
}
