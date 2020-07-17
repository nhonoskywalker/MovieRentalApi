namespace MRAPP.Messages.Authentication
{
    using Newtonsoft.Json;
    using System.Runtime.Serialization;

    [DataContract]
    public class LogInWebRequest
    {
        [DataMember]
        [JsonProperty("email")]
        [JsonRequired]
        public string Email { get; set; }

        [DataMember]
        [JsonProperty("password")]
        [JsonRequired]
        public string Password { get; set; }
    }
}
