﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MRAPP.Data.Movies
{
    public class MovieEntity
    {
        [Key]
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsRented { get; set; }

        public DateTime RentalDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
