using MRAPP.Insfrastructure.Models.Movies;
using System.Runtime.Serialization;

namespace MRAPP.Messages.Movies
{
    [DataContract]
    public class UpdateMovieWebResponse : WebResponse
    {
        [DataMember]
        public MovieModel Data { get; set; }
    }
}
