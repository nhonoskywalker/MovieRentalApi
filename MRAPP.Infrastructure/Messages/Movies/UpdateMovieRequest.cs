using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MRAPP.Infrastructure.Messages.Movies
{
    [DataContract]
    public class UpdateMovieRequest
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool IsRented { get; set; }

        [DataMember]
        public DateTime RentalDate { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
