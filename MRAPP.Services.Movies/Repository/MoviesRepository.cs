namespace MRAPP.Services.Movies.Repository
{
    using MRAPP.Insfrastructure.Models.Movies;
    using MRAPP.Services.Movies.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using MRAPP.Data.Movies;
    using MRAPP.Infrastructure.Data;
    using System.Data.Entity;

    public class MoviesRepository : IMoviesRepository
    {
        private readonly IApplicationDbContext appDbContext;

        public MoviesRepository(IApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<MovieModel> GetMovieById(Guid id)
        {
            var result = await this.appDbContext.Movies.FirstOrDefaultAsync(x => x.Id == id); //.FindAsync(id);

            return result?.AsModel();
        }

        public async Task<IEnumerable<MovieModel>> GetMovies()
        {
            var result = await this.appDbContext.Movies.ToListAsync();
               
            return result.AsModel();
        }


    }
}
