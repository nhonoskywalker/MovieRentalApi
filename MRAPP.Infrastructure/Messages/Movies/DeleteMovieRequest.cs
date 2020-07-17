using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MRAPP.Infrastructure.Messages.Movies
{
    [DataContract]
    public class DeleteMovieRequest
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
