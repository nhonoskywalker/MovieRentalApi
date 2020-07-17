namespace MRAPP.Services.Movies.Repository
{
    using MRAPP.Data.Movies;
    using MRAPP.Infrastructure.Data;
    using MRAPP.Insfrastructure.Models.Movies;
    using MRAPP.Services.Movies.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class MoviesRepository : IMoviesRepository
    {
        private readonly IApplicationDbContext appDbContext;

        public MoviesRepository(IApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<MovieModel> GetMovieByIdAsync(Guid id)
        {
            var result = this.appDbContext.Movies.FirstOrDefault(m => m.Id == id);

            return result?.AsModel();
        }

        public async Task<IEnumerable<MovieModel>> GetMoviesAsync()
        {
            var result = this.appDbContext.Movies.Where(movie => movie.IsDeleted == false).ToList();

            return result?.AsModel();
        }

        public async Task<MovieModel> AddMovieAsync(MovieEntity entity)
        {
            this.appDbContext.Movies.Add(entity);
            await this.appDbContext.SaveChangesAsync();

            return entity.AsModel();
        }

        public async Task<MovieModel> UpdateMovieAsync(MovieEntity entity)
        {
            var moviEntity = this.appDbContext.Movies.FirstOrDefault(m => m.Id == entity.Id);

            moviEntity.Title = entity.Title;
            moviEntity.Description = entity.Description;
            moviEntity.IsRented = entity.IsRented;
            moviEntity.RentalDate = entity.RentalDate;
            moviEntity.IsDeleted = entity.IsDeleted;

            this.appDbContext.Movies.Update(moviEntity);
            await this.appDbContext.SaveChangesAsync();

            return moviEntity.AsModel();
        }

        public async Task<MovieModel> DeleteMovieAsync(MovieEntity entity)
        {
            var moviEntity = this.appDbContext.Movies.FirstOrDefault(m => m.Id == entity.Id);
            
            moviEntity.IsDeleted = entity.IsDeleted;

            this.appDbContext.Movies.Update(moviEntity);
            await this.appDbContext.SaveChangesAsync();

            return moviEntity.AsModel();
        }
    }
}
