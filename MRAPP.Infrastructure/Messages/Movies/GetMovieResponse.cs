namespace MRAPP.Insfrastructure.Messages.Movies
{
    using MRAPP.Infrastructure.Messages;
    using MRAPP.Insfrastructure.Models.Movies;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetMovieResponse : Response
    {
        [DataMember]
        public IEnumerable<MovieModel> Data { get; set; }
    }
}
