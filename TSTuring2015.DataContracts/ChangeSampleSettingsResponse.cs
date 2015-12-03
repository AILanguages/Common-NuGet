
namespace TSTuring2015.DataContracts
{
    using System.Runtime.Serialization;
    using ScreenModels;

    [KnownType(typeof(SampleSettings))]
    [DataContract]
    public class ChangeSampleSettingsResponse : Response
    {
        [DataMember]
        public SampleSettings Settings { get; set; }
    }
}
