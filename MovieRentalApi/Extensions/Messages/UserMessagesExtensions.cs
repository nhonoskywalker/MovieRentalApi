namespace MRAPP.Extensions.Messages
{
    using MRAPP.Insfrastructure.Messages.UserRegistration;
    using MRAPP.Messages.Users;

    public static class UserMessagesExtensions
    {
        public static UserRegistrationRequest AsRequest(this UserRegistrationWebRequest request)
        {
            var result = new UserRegistrationRequest
            {
                Username = request.UserName,
                Password = request.Password,
                Email = request.Email,
                Fullname = request.FirstName + " " + request.LastName,
                Role = request.Role
            };

            return result;
        }

        public static UserRegistrationWebResponse AsWebResponse(this UserRegistrationResponse response)
        {
            var result = new UserRegistrationWebResponse
            {
                Errors = response.Errors,
                Message = response.Message,
                StatusCode = response.StatusCode,
                IsSuccessful = response.IsSuccessful
            };

            return result;
        }
    }
}
