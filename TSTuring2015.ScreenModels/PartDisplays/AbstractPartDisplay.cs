//-----------------------------------------------------------------------
// <copyright file="AbstractPartDisplay.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.PartDisplays
{
    public class AbstractPartDisplay
    {
        public int Selection { get; set; }

        public int ListNumber { get; set; }
        public int Part { get; set; }

        public int Count { get; set; }
        public string Title { get; set; }
        public string Matches { get; set; }

        public int PhraseLength { get; set; }
        public string PhraseName { get; set; }
    }
}