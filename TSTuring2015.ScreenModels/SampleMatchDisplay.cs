//-----------------------------------------------------------------------
// <copyright file="SampleMatchDisplay.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels
{
    using System.Collections.Generic;

    public class SampleMatchDisplay
    {
        public string CurrentFile { get; set; }
        public string[] FileChoices { get; set; }
        public List<AnnotatedMatch> MatchList { get; set; }
        public string Description { get; set; }
    }
}