using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class ChooseSampleFileRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public int Selection { get; set; }
    }
}
