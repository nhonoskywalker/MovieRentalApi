using System;

namespace MRAPP.Insfrastructure.Models.Movies
{
    public class MovieModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsRented { get; set; }

        public bool IsDeleted { get; set; }
    }
}
