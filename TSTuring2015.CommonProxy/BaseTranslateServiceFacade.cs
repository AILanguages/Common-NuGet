//-----------------------------------------------------------------------
// <copyright file="BaseTranslateServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using Contracts;
    using DataContracts;
    using ScreenModels;

    public abstract class BaseTranslateServiceFacade
    {
        private readonly ITranslateService _translateClientProxy;

        protected BaseTranslateServiceFacade(ITranslateService translateService)
        {
            _translateClientProxy = translateService;
        }

        protected abstract GetScreenRequest GetScreenRequest();
        protected abstract NewMatchRequest GetNewMatchRequest(Match match);

        protected GetTextResponse GetTextResponse(GetTextRequest request)
        {
            return _translateClientProxy.GetText(request);
        }

        public ScreenPresentation GetCurrentScreen()
        {
            var screenReturned = new ScreenPresentation();

            var request = GetScreenRequest();
            var response = _translateClientProxy.GetCurrentScreenModel(request);

            if (response.Success)
            {
                screenReturned.ScreenFound = true;
                screenReturned.ScreenModel = response.ScreenModel;
                screenReturned.ScreenName = response.ScreenName;
            }
            else
            {
                screenReturned.ScreenFound = false;
                screenReturned.ScreenModel = null;
            }

            return screenReturned;
        }

        public MatchPatternPresentation GetMatchFor(Match match)
        {
            var request = GetNewMatchRequest(match);
            return GetAMatchFor(match, _translateClientProxy.GetData(request));
        }

        private MatchPatternPresentation GetAMatchFor(Match match, NewMatchResponse response)
        {
            var matchPattern = new MatchPatternPresentation();

            if (response.Success)
            {
                matchPattern.MatchesSuccessfullyFound = true;
                matchPattern.MatchId = response.UserKey;
                matchPattern.ExpiryDate = response.ExpirationDate;
                matchPattern.MenuType = response.MenuType;
            }
            else
            {
                matchPattern.MatchesSuccessfullyFound = false;
                matchPattern.Message = response.Message;
                matchPattern.Edit = match;
            }

            return matchPattern;
        }
    }
}