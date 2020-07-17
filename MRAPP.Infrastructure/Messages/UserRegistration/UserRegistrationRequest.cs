namespace MRAPP.Insfrastructure.Messages.UserRegistration
{
    using MRAPP.Infrastructure.Messages;
    using System.Runtime.Serialization;

    [DataContract]
    public class UserRegistrationRequest : Request
    {
        [DataMember]
        public string Username;

        [DataMember]
        public string Email;

        [DataMember]
        public string Password;

        [DataMember]
        public string Fullname;

        [DataMember]
        public string Role;

        [DataMember]
        public string Address;

    }
}
