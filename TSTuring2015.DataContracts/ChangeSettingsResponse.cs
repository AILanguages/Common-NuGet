
namespace TSTuring2015.DataContracts
{
    using System.Runtime.Serialization;
    using ScreenModels;

    [KnownType(typeof(MatchSettings))]
    [DataContract]
    public class ChangeSettingsResponse : Response
    {
        [DataMember]
        public MatchSettings Settings { get; set; }
    }
}
