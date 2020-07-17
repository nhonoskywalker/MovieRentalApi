namespace MRAPP.Services.Badges
{
    using MRAPP.Insfrastructure.Messages.Movies;
    using MRAPP.Services.Movies;
    using MRAPP.Services.Movies.Repository;
    using System.Threading.Tasks;

    public class MovieService : IMovieService
    {
        private readonly IMoviesRepository moviesRepository;

        public MovieService(IMoviesRepository moviesRepository)
        {
            this.moviesRepository = moviesRepository;
        }

        public async Task<GetMovieByIdResponse> GetMovieById(GetMovieByIdRequest request)
        {
            var result = new GetMovieByIdResponse()
            {
                Data = await this.moviesRepository.GetMovieById(request.Id)
            };

            return result;
        }

        public async Task<GetMovieResponse> GetMovies(GetMoviesRequest request)
        {
            var result = new GetMovieResponse
            {
                Data = await this.moviesRepository.GetMovies()
            };

            return result;
        }
    }
}
