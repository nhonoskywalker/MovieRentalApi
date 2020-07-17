using MRAPP.Infrastructure.Models.Movies;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MRAPP.Infrastructure.Messages.Users
{
    [DataContract]
    public class GetUsersResponse : Response
    {
        [DataMember]
        public IEnumerable<UserModel> Data { get; set; }
    }
}
