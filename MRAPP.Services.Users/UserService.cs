namespace MRAPP.Services.Users
{
    using MRAPP.Data.Entities.Users;
    using MRAPP.Insfrastructure.Messages.UserRegistration;
    using MRAPP.Services.Users.Processes.UserRegistration;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Threading.Tasks;
    using MRAPP.Infrastructure.Messages.Users;
    using MRAPP.Services.Users.Repository;
    using MRAPP.Services.Users.Extentsions;

    public class UserService : IUserService
    {
        private readonly UserManager<UserEntity> userManager;
        private readonly RoleManager<RoleEntity> roleManager;
        private readonly IUserRepository userRepository;

        public UserService(UserManager<UserEntity> userManager, RoleManager<RoleEntity> roleManager, IUserRepository userRepository)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.userRepository = userRepository;
        }

        public async Task<GetUsersResponse> GetUsersAsync(GetUsersRequest request)
        {
            var result = new GetUsersResponse
            {
                Data = await this.userRepository.GetUsersAsync()
            };

            return result;
        }

        public async Task<UserRegistrationResponse> RegisterUserAsync(UserRegistrationRequest request)
        {
            var userRegistrationContext = new UserRegistrationContext(request, this.userManager, this.roleManager);
            var result = await userRegistrationContext.ProcessAsync();
            return result;
        }
    }
}
