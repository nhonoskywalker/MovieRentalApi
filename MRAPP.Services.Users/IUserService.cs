namespace MRAPP.Services.Users
{
    using MRAPP.Infrastructure.Messages.Users;
    using MRAPP.Insfrastructure.Messages.UserRegistration;
    using System.Threading.Tasks;

    public interface IUserService
    {
        Task<UserRegistrationResponse> RegisterUserAsync(UserRegistrationRequest request);

        Task<GetUsersResponse> GetUsersAsync(GetUsersRequest request);
    }
}
