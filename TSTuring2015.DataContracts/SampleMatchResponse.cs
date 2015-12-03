using System.Collections.Generic;
using System.Runtime.Serialization;
using TSTuring2015.ScreenModels;

namespace TSTuring2015.DataContracts
{
    [KnownType(typeof(SampleMatchDisplay))]
    [KnownType(typeof(List<AnnotatedMatch>))]
    [KnownType(typeof(AnnotatedMatch))]
    [KnownType(typeof(Match))]
    [DataContract]
    public class SampleMatchResponse : Response 
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public SampleMatchDisplay SampleMatchDisplay { get; set; }
    }
}
