using MRAPP.Data.Movies;
using System.Data.Entity;

namespace MRAPP.Infrastructure.Data
{
    public interface IApplicationDbContext
    {
        public DbSet<MovieEntity> Movies { get; set; }
    }
}
