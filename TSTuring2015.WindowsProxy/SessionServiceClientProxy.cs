//-----------------------------------------------------------------------
// <copyright file="SessionServiceClientProxy.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.WindowsProxy
{
    using CommonProxy;
    using Contracts;
    using DataContracts;

    public class SessionServiceClientProxy : AbstractServiceClientFactory<ISessionService>, ISessionService
    {
        public GetIDResponse GetID(GetIDRequest usePatternRequest)
        {
            return Channel.GetID(usePatternRequest);
        }
    }
}