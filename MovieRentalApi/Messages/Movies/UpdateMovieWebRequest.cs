using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MRAPP.Messages.Movies
{
    [DataContract]
    public class UpdateMovieWebRequest
    {
        [DataMember]
        [JsonRequired]
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [DataMember]
        [JsonRequired]
        public string Title { get; set; }

        [JsonRequired]
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool IsRented { get; set; }


        [DataMember]
        public DateTime Rentaldate { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
