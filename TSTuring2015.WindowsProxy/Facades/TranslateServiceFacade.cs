//-----------------------------------------------------------------------
// <copyright file="TranslateServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.WindowsProxy.Facades
{
    using CommonProxy;
    using Contracts;
    using DataContracts;
    using ScreenModels;

    public class TranslateServiceFacade : BaseTranslateServiceFacade
    {
        public TranslateServiceFacade(ITranslateService translateService) : base(translateService)
        { }

        protected override GetScreenRequest GetScreenRequest()
        {
            return new GetScreenRequest { UserKey = WindowsContext.UserKey };
        }

        protected override NewMatchRequest GetNewMatchRequest(Match match)
        {
            return new NewMatchRequest { DataToMatch = match, UserKey = WindowsContext.UserKey };
        }
    }
}