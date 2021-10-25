using Microsoft.EntityFrameworkCore;
using MRAPP.Data.Entities.Users;
using MRAPP.Infrastructure.Data;
using MRAPP.Infrastructure.Models.Movies;
using MRAPP.Services.Users.Extentsions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MRAPP.Services.Users.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IApplicationDbContext appDbContext;

        public UserRepository(IApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<UserModel>> GetUsersAsync()
        {
            var result = await this.appDbContext.Users.ToListAsync();

            return result?.AsModel();
        }
    }
}
