namespace MRAPP.Services.Movies.Repository
{
    using MRAPP.Insfrastructure.Models.Movies;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMoviesRepository
    {
        Task<IEnumerable<MovieModel>> GetMovies();

        Task<MovieModel> GetMovieById(Guid id);
    }
}
