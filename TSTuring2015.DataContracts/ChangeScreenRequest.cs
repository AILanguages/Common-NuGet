using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class ChangeScreenRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public int Selection { get; set; }

        [DataMember]
        public int Type { get; set; }

        [DataMember]
        public int Part { get; set; }
    }
}
