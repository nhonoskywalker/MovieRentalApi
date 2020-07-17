namespace MRAPP.Insfrastructure.Messages.Movies
{
    using MRAPP.Infrastructure.Messages;
    using MRAPP.Insfrastructure.Models.Movies;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetMovieByIdResponse : Response
    {
        [DataMember]
        public MovieModel Data { get; set; }
    }
}
