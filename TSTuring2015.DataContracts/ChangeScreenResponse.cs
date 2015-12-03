
namespace TSTuring2015.DataContracts
{
    using System.Runtime.Serialization;
    using ScreenModels.FullScreenModels;
    using ScreenModels.PartDisplays;

    [KnownType(typeof(FullScreenModel))]
    [KnownType(typeof(AbstractPartDisplay))]
    [DataContract]
    public class ChangeScreenResponse : Response
    {
        [DataMember]
        public string Screen { get; set; }
    }
}
