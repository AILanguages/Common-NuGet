using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class ChooseSampleFileResponse : Response 
    {
        [DataMember]
        public string Screen { get; set; }
    }
}
