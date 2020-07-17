namespace MRAPP.Insfrastructure.Messages.LogIn
{
    using MRAPP.Infrastructure.Messages;
    using System.Runtime.Serialization;

    [DataContract]
    public class LogInRequest : Request
    {
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

    }
}
