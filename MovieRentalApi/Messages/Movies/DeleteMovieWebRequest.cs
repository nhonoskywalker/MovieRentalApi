using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace MRAPP.Messages.Movies
{
    [DataContract]
    public class DeleteMovieWebRequest : WebRequest
    {
        [DataMember]
        [JsonRequired]
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
