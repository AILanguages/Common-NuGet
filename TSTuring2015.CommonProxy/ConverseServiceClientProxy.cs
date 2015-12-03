//-----------------------------------------------------------------------
// <copyright file="ConverseServiceClientProxy.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using Contracts;
    using DataContracts;

    public class ConverseServiceClientProxy : AbstractServiceClientFactory<IConverseService>, IConverseService
    {
        public ConverseResponse GetConversationData(NewMatchRequest request)
        {
            return Channel.GetConversationData(request);
        }

        public ConverseResponse GetContext(NewMatchRequest request)
        {
            return Channel.GetContext(request);
        }

        public ConverseResponse RestartConversation(NewMatchRequest request)
        {
            return Channel.RestartConversation(request);
        }
    }
}