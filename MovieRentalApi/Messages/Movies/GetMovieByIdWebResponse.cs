namespace MRAPP.Messages.Movies
{
    using MRAPP.Insfrastructure.Models.Movies;
    using Newtonsoft.Json;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetMovieByIdWebResponse : WebResponse
    {
        [DataMember]
        [JsonProperty("data")]
        public MovieModel Data { get; set; }
    }
}
