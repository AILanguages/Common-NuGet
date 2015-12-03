
namespace TSTuring2015.DataContracts
{
    using System.Runtime.Serialization;
    using ScreenModels;

    [KnownType(typeof(Match))]
    [KnownType(typeof(MatchSettings))]
    [DataContract]
    public class GetSettingsResponse : Response
    {
        [DataMember]
        public MatchSettings Settings { get; set; }
    }
}
