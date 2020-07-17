using MRAPP.Insfrastructure.Models.Movies;
using MRAPP.Messages;
using System.Runtime.Serialization;

namespace MRAPP.Messages.Movies
{
    [DataContract]
    public class DeleteMovieWebResponse : WebResponse
    {
        [DataMember]
        public MovieModel Data { get; set; }
    }
}
