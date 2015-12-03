using System.Runtime.Serialization;
using TSTuring2015.ScreenModels;

namespace TSTuring2015.DataContracts
{
    [KnownType(typeof(Match))]
    [DataContract]
    public class NewMatchRequest
    {
        [DataMember]
        public Match DataToMatch { get; set; }

        [DataMember]
        public string UserKey { get; set; }
    }
}
