using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class GetScreenRequest
    {
        [DataMember]
        public string UserKey { get; set; }
    }
}
