using MRAPP.Data.Movies;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MRAPP.Data.Entities.Users;

namespace MRAPP.Infrastructure.Data
{
    public interface IApplicationDbContext
    {
        public DbSet<MovieEntity> Movies { get; set; }

        public DbSet<UserEntity> Users { get; set; }

        Task SaveChangesAsync();

        void SaveChanges();

    }
}
