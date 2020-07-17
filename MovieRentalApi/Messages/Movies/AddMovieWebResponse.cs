using MRAPP.Insfrastructure.Models.Movies;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MRAPP.Messages.Movies
{
    [DataContract]
    public class AddMovieWebResponse : WebResponse
    {
        [DataMember]
        public MovieModel Data { get; set; }
    }
}
