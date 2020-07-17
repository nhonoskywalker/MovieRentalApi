namespace MRAPP.Services.AuthToken
{
    using MRAPP.Data.Entities.Users;
    using System.Collections.Generic;

    public interface ITokenService
    {
        string GenerateToken(UserEntity userEntity, IList<string> roles);
    }
}
