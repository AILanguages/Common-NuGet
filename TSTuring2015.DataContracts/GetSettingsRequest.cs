﻿using System.Runtime.Serialization;

namespace TSTuring2015.DataContracts
{
    [DataContract]
    public class GetSettingsRequest
    {
        [DataMember]
        public string UserKey { get; set; }
    }
}
