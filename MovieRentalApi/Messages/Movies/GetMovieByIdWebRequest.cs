namespace MRAPP.Messages.Movies
{
    using Newtonsoft.Json;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetMovieByIdWebRequest : WebRequest
    {
        [DataMember]
        [JsonRequired]
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
