namespace MRAPP.Services.Movies
{
    using MRAPP.Data.Movies;
    using MRAPP.Infrastructure.Messages.Movies;
    using MRAPP.Insfrastructure.Messages.Movies;
    using MRAPP.Services.Movies.Repository;
    using System.Threading.Tasks;

    public class MovieService : IMovieService
    {
        private readonly IMoviesRepository moviesRepository;

        public MovieService(IMoviesRepository moviesRepository)
        {
            this.moviesRepository = moviesRepository;
        }

        public async Task<GetMovieByIdResponse> GetMovieByIdAsync(GetMovieByIdRequest request)
        {
            var result = new GetMovieByIdResponse()
            {
                Data = await this.moviesRepository.GetMovieByIdAsync(request.Id)
            };

            return result;
        }

        public async Task<GetMovieResponse> GetMoviesAsync(GetMoviesRequest request)
        {
            var result = new GetMovieResponse
            {
                Data = await this.moviesRepository.GetMoviesAsync()
            };

            return result;
        }

        public async Task<AddMovieResponse> AddMovieAsync(AddMovieRequest request)
        {
            var entity = new MovieEntity
            {
                Title = request.Title,
                Description = request.Description,
                IsDeleted = request.IsDeleted,
                IsRented = request.IsRented
            };

            var result = new AddMovieResponse
            {
                Data = (await this.moviesRepository.AddMovieAsync(entity))
            };

            return result;
        }

        public async Task<UpdateMovieResponse> UpdateMovieAsync(UpdateMovieRequest request)
        {
            var entity = new MovieEntity
            {
                Id = request.Id,
                Title = request.Title,
                Description = request.Description,
                IsDeleted = request.IsDeleted,
                RentalDate = request.RentalDate,
                IsRented = request.IsRented
            };

            var result = new UpdateMovieResponse
            {
                Data = await this.moviesRepository.UpdateMovieAsync(entity)
            };

            return result;
        }

        public async Task<DeleteMovieResponse> DeleteMovieAsync(DeleteMovieRequest request)
        {
            var entity = new MovieEntity
            {
                Id = request.Id,
                IsDeleted = true,
            };

            var result = new DeleteMovieResponse
            {
                Data = await this.moviesRepository.DeleteMovieAsync(entity)
            };

            return result;
        }
    }
}
