namespace MRAPP.Messages.Movies
{
    using MRAPP.Insfrastructure.Models.Movies;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetMoviesWebResponse : WebResponse
    {
        [DataMember]
        [JsonProperty("data")]
        public IEnumerable<MovieModel> Data { get; set; }
    }
}
