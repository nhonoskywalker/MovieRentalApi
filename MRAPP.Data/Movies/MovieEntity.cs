using System;
using System.Collections.Generic;
using System.Text;

namespace MRAPP.Data.Movies
{
    public class MovieEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsRented { get; set; }

        public bool IsDeleted { get; set; }
    }
}
