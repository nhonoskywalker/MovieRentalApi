using System;

namespace MRAPP.Infrastructure.Models.Movies
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Fullname { get; set; }

        public string Address { get; set; }
    }
}
