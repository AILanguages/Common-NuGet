
namespace TSTuring2015.DataContracts
{
    using System.Runtime.Serialization;
    using ScreenModels;

    [DataContract]
    public class ChangeSettingsRequest
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public MatchSettings Settings { get; set; }
    }
}
