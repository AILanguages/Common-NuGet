
namespace TSTuring2015.DataContracts
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using ScreenModels;

    [KnownType(typeof(TranslatePair))]
    [DataContract]
    public class GetTranslationResponse : Response
    {
        [DataMember]
        public List<TranslationPair> TranslationPair { get; set; }
    }
}
