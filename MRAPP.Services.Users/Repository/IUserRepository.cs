using MRAPP.Infrastructure.Models.Movies;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MRAPP.Services.Users.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserModel>> GetUsersAsync();
    }
}
