using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class TranslationPair
    {
        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public string Target { get; set; }
    }
}
