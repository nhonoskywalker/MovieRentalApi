namespace MRAPP.Messages.Movies
{
    using Newtonsoft.Json;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetMovieByIdWebRequest
    {
        [DataMember]
        [JsonRequired]
        [JsonProperty("id")]
        public Guid Id { get; set; }

       
    }
}
