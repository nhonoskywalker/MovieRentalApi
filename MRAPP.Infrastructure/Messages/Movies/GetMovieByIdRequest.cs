namespace MRAPP.Insfrastructure.Messages.Movies
{
    using MRAPP.Infrastructure.Messages;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetMovieByIdRequest : Request
    {
        [DataMember]
        public Guid Id { get; set; }
    }
}
