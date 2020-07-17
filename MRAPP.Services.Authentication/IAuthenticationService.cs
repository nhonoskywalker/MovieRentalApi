namespace MRAPP.Services.Authentication
{
    using MRAPP.Insfrastructure.Messages.LogIn;
    using System.Threading.Tasks;

    public interface IAuthenticationService
    {
        Task<LogInResponse> AuthenticateUserAsync(LogInRequest request);
    }
}
