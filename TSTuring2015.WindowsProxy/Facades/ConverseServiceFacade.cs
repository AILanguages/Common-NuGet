//-----------------------------------------------------------------------
// <copyright file="ConverseServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.WindowsProxy.Facades
{
    using Contracts;
    using CommonProxy;
    using DataContracts;
    using ScreenModels;
    using ScreenModels.Conversation;

    public class ConverseServiceFacade : BaseConverseServiceFacade
    {
        public ConverseServiceFacade(IConverseService converseService) : base(converseService)
        { }

        public ConversationData UpdateConversation(Match match)
        {
            var request = new NewMatchRequest { UserKey = WindowsContext.UserKey, DataToMatch = match };

            var response = ConverseService.GetConversationData(request);

            return response.Conversation;
        }

        public ConversationData GetContext(Match match)
        {
            var request = new NewMatchRequest { UserKey = WindowsContext.UserKey, DataToMatch = match };

            var response = ConverseService.GetContext(request);

            return response.Conversation;
        }

        public void RestartConversation(Match match)
        {
            var request = new NewMatchRequest { UserKey = WindowsContext.UserKey, DataToMatch = match };

            ConverseService.RestartConversation(request);
        }
    }
}