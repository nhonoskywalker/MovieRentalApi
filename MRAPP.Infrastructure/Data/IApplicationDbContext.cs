using MRAPP.Data.Movies;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MRAPP.Infrastructure.Data
{
    public interface IApplicationDbContext
    {
        public DbSet<MovieEntity> Movies { get; set; }

        Task SaveChangesAsync();

        void SaveChanges();

    }
}
