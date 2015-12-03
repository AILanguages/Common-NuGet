
namespace TSTuring2015.DataContracts
{
    using System.Runtime.Serialization;
    using ScreenModels;

    [DataContract]
    public class ChangeSampleSettingsRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public SampleSettings Settings { get; set; }
    }
}
