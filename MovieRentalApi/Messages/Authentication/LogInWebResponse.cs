namespace MRAPP.Messages.Authentication
{
    using Newtonsoft.Json;

    public class LogInWebResponse : WebResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
