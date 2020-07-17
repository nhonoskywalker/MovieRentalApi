namespace MRAPP.Services.Movies
{
    using MRAPP.Insfrastructure.Messages.Movies;
    using System.Threading.Tasks;

    public interface IMovieService
    {
        Task<GetMovieResponse> GetMovies(GetMoviesRequest request);

        Task<GetMovieByIdResponse> GetMovieById(GetMovieByIdRequest request);

    }
}
