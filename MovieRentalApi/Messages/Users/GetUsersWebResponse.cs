using MRAPP.Infrastructure.Models.Movies;
using MRAPP.Messages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MovieRentalApi.Messages.Users
{
    [DataContract]
    public class GetUsersWebResponse : WebResponse
    {
        [DataMember]
        [JsonProperty("data")]
        public IEnumerable<UserModel> Data { get; set; }
    }
}
