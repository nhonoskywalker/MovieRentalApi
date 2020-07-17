namespace MRAPP.Data.Entities.Users
{
    using Microsoft.AspNetCore.Identity;
    using System;

    public class UserEntity : IdentityUser<Guid>
    {
        public string Fullname { get; set; }

        public string Address { get; set; }
    }
}
