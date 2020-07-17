namespace MRAPP.Services.Movies
{
    using MRAPP.Infrastructure.Messages.Movies;
    using MRAPP.Insfrastructure.Messages.Movies;
    using System.Threading.Tasks;

    public interface IMovieService
    {
        Task<GetMovieResponse> GetMoviesAsync(GetMoviesRequest request);

        Task<GetMovieByIdResponse> GetMovieByIdAsync(GetMovieByIdRequest request);

        Task<AddMovieResponse> AddMovieAsync(AddMovieRequest request);

        Task<UpdateMovieResponse> UpdateMovieAsync(UpdateMovieRequest request);

        Task<DeleteMovieResponse> DeleteMovieAsync(DeleteMovieRequest request);
    }
}
