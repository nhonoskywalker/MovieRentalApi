namespace MRAPP.Services.Movies.Extensions
{
    using MRAPP.Data.Movies;
    using MRAPP.Insfrastructure.Models.Movies;
    using System.Collections.Generic;
    using System.Linq;

    public static class MoviesExtensions
    {
        public static IEnumerable<MovieModel> AsModel(this IEnumerable<MovieEntity> entities)
        {
            var result = entities.Select(entity => entity.AsModel());

            return result;
        }

        public static MovieModel AsModel(this MovieEntity entity)
        {
            var result = new MovieModel
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                IsDeleted = entity.IsDeleted,
                RentalDate = entity.RentalDate,
                IsRented = entity.IsRented
            };

            return result;
        }

    }
}
