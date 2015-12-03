//-----------------------------------------------------------------------
// <copyright file="BaseServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.WindowsProxy.Facades
{
    using Contracts;
    using DataContracts;

    public class BaseServiceFacade
    {
        public static void SetUpFacade(ISessionService sessionService)
        {
            // ensure valid link to server in place - create a new user key!
            var request = new GetIDRequest { UserKey = WindowsContext.UserKey };
            var response = sessionService.GetID(request);

            if (!response.Success) return;

            WindowsContext.UserKey = response.UserKey;
        }
    }
}