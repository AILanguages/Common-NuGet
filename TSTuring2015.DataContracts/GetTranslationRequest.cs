using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class GetTranslationRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public string TextIn { get; set; }
    }
}
