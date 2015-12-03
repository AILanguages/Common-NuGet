//-----------------------------------------------------------------------
// <copyright file="GetaMatch.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using DataContracts;
    using ScreenModels;

    public class GetaMatch
    {
        protected MatchPatternPresentation GetAMatchFor(Match match, NewMatchResponse response)
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