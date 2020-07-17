using MRAPP.Insfrastructure.Models.Movies;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MRAPP.Infrastructure.Messages.Movies
{
    [DataContract]
    public class UpdateMovieResponse : Response
    {
        [DataMember]
        public MovieModel Data { get; set; }
    }
}
