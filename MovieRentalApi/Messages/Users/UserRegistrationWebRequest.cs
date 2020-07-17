namespace MRAPP.Messages.Users
{
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

    public class UserRegistrationWebRequest : WebRequest
    {
        [JsonProperty("username")]
        [Required, MinLength(5)]
        public string UserName { get; set; }

        [JsonProperty("password")]
        [Required, MinLength(8)]
        public string Password { get; set; }

        [JsonProperty("email")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [JsonProperty("firstname")]
        [Required, MinLength(1)]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        [Required, MinLength(1)]
        public string LastName { get; set; }

        [JsonProperty("role")]
        [Required]
        public string Role { get; set; }

        [JsonProperty("address")]
        [Required]
        public string Address { get; set; }
    }
}
