using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class GetSampleSettingsRequest
    {
        [DataMember]
        public string UserKey { get; set; }
    }
}
