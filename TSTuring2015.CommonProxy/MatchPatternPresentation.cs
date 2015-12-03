//-----------------------------------------------------------------------
// <copyright file="MatchPatternPresentation.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using ScreenModels;
    using System;

    public class MatchPatternPresentation
    {
        public string MatchId { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool MatchesSuccessfullyFound { get; set; }
        public Match Edit { get; set; }
        public string MenuType { get; set; }
        public string Message { get; set; }
    }
}
