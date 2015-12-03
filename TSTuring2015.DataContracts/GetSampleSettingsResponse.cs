
namespace TSTuring2015.DataContracts
{
    using System.Runtime.Serialization;
    using ScreenModels;

    [KnownType(typeof(Match))]
    [KnownType(typeof(SampleSettings))]
    [DataContract]
    public class GetSampleSettingsResponse : Response
    {
        [DataMember]
        public SampleSettings Settings { get; set; }
    }
}
