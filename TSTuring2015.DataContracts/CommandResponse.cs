using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class CommandResponse : Response 
    {
        [DataMember]
        public string Edit { get; set; }

        [DataMember]
        public bool DoEdit { get; set; }

        [DataMember]
        public string ScreenName { get; set; }
    }
}
