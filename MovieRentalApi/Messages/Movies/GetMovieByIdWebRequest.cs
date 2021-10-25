namespace MRAPP.Messages.Movies
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class GetMovieByIdWebRequest : WebRequest
    {
        [DataMember]
        [Required]
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
