using MRAPP.Data.Entities.Users;
using MRAPP.Infrastructure.Models.Movies;
using System.Collections.Generic;
using System.Linq;

namespace MRAPP.Services.Users.Extentsions
{
    public static class UsersExtensions
    {
        public static UserModel AsModel(this UserEntity entity)
        {
            var result = new UserModel
            {
                Id = entity.Id,
                Email = entity.Email,
                Fullname = entity.Fullname,
                Address = entity.Address
            };

            return result;
        }

        public static IEnumerable<UserModel> AsModel(this IEnumerable<UserEntity> entities)
        {
            var result = entities.Select(entity => entity.AsModel());

            return result;
        }
    }
}
