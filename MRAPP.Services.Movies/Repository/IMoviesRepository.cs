namespace MRAPP.Services.Movies.Repository
{
    using MRAPP.Data.Movies;
    using MRAPP.Insfrastructure.Models.Movies;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMoviesRepository
    {
        Task<IEnumerable<MovieModel>> GetMoviesAsync();

        Task<MovieModel> GetMovieByIdAsync(Guid id);

        Task<MovieModel> AddMovieAsync(MovieEntity entity);

        Task<MovieModel> UpdateMovieAsync(MovieEntity entity);

        Task<MovieModel> DeleteMovieAsync(MovieEntity entity);
    }
}
