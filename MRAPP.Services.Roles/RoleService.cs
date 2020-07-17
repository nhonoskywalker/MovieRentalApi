using Microsoft.AspNetCore.Identity;
using MRAPP.Data.Entities.Users;
using System.Threading.Tasks;

namespace MRAPP.Services.Roles
{
    public class RoleService : IRoleService
    {
        public RoleService()
        {
          
        }

        public static async Task CreateRolesAsync(RoleManager<RoleEntity> roleManager)
        {
            var roles = new RoleEntity[] {
                new RoleEntity{ Name = "Admin"},
                new RoleEntity{ Name = "Customer"}
            };

            foreach (var role in roles)
            {
                await roleManager.CreateAsync(role);
            }
        }
    }
}
