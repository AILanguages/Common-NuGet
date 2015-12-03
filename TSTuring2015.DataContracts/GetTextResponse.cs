
namespace TSTuring2015.DataContracts
{
    using System.Runtime.Serialization;
    using ScreenModels;

    [KnownType(typeof(Match))]
    [DataContract]
    public class GetTextResponse : Response
    {
        [DataMember]
        public string Screen { get; set; }

        [DataMember]
        public Match Match { get; set; }

        [DataMember]
        public bool EditFound { get; set; }
    }
}
