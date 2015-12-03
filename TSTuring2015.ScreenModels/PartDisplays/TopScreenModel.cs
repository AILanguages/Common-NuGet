//-----------------------------------------------------------------------
// <copyright file="TopScreenModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.PartDisplays
{
    public class TopScreenModel 
    {
        public TextPartDisplay MatchedText { get; set; }
        public TextListPartDisplay Operators { get; set; }
        public TextListPartDisplay Attributes { get; set; }
        public TextPartDisplay PhraseName { get; set; }
    }
}