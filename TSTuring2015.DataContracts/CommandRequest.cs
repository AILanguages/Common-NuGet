using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class CommandRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public Command CommandNo { get; set; }
    }
}
