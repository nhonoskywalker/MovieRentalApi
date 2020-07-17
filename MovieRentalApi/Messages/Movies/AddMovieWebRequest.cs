using MRAPP.Messages;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace MRAPP.Messages.Movies
{
    [DataContract]
    public class AddMovieWebRequest : WebRequest
    {
        [DataMember]
        [JsonRequired]
        [JsonProperty("title")]
        public string Title { get; set; }

        [DataMember]
        [JsonProperty("description")]
        [JsonRequired]
        public string Description { get; set; }

        [JsonProperty("isRented")]
        [DataMember]
        public bool IsRented { get; set; }

        [JsonProperty("isDeleted")]
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
