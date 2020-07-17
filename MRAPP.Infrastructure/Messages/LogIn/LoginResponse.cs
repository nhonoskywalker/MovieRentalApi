namespace MRAPP.Insfrastructure.Messages.LogIn
{
    using MRAPP.Infrastructure.Messages;
    using System.Runtime.Serialization;

    [DataContract]
    public class LogInResponse : Response
    {
        [DataMember]
        public string Data { get; set; }
    }
}
