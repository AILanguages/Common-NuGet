using System;
using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class NewMatchResponse : Response 
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public string MenuType { get; set; }

        [DataMember]
        public DateTime ExpirationDate { get; set; }
    }
}
