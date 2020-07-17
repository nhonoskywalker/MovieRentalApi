namespace MRAPP.Extensions.Messages
{
    using MovieRentalApi.Messages.Users;
    using MRAPP.Infrastructure.Messages.Users;
    using MRAPP.Insfrastructure.Messages.UserRegistration;
    using MRAPP.Messages.Users;

    public static class UserMessagesExtensions
    {
        public static UserRegistrationRequest AsRequest(this UserRegistrationWebRequest webRequest)
        {
            var result = new UserRegistrationRequest
            {
                Username = webRequest.UserName,
                Password = webRequest.Password,
                Email = webRequest.Email,
                Fullname = webRequest.FirstName + " " + webRequest.LastName,
                Role = webRequest.Role,
                Address = webRequest.Address
            };

            return result;
        }

        public static GetUsersRequest AsRequest(this GetUsersWebRequest webRequest)
        {
            var result = new GetUsersRequest
            {
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

        public static GetUsersWebResponse AsWebResponse(this GetUsersResponse response)
        {
            var result = new GetUsersWebResponse
            {
                Errors = response.Errors,
                Message = response.Message,
                StatusCode = response.StatusCode,
                IsSuccessful = response.IsSuccessful,
                Data = response.Data
            };

            return result;
        }
    }
}
