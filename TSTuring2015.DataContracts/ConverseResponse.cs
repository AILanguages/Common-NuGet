namespace TSTuring2015.DataContracts
{
    using System;
    using ScreenModels.Conversation;
    using System.Runtime.Serialization;

    [KnownType(typeof(ConversationData))]
    [KnownType(typeof(Dialog))]
    [KnownType(typeof(PronounTrackingData))]
    [KnownType(typeof(HighTrackingData))]
    [KnownType(typeof(TrackingData))]
    [KnownType(typeof(HighContext))]
    [KnownType(typeof(Dialog))]
    [KnownType(typeof(PronounContext))]
    [DataContract]
    public class ConverseResponse : Response
    {
        [DataMember]
        public string UserKey { get; set; }

        [DataMember]
        public string MenuType { get; set; }

        [DataMember]
        public DateTime ExpirationDate { get; set; }

        [DataMember]
        public ConversationData Conversation { get; set; }
    }
}
