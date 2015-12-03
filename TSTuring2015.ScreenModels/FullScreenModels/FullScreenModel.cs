//-----------------------------------------------------------------------
// <copyright file="FullScreenModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.FullScreenModels
{
    public class FullScreenModel
    {
        public string ScreenName { get; set; }
        public string CssScreen { get; set; }
        public string Description { get; set; }
        public string PartLs { get; set; }
        public string Structure { get; set; }
        public string QuestionText { get; set; }

        public string Translation { get; set; } // text in target language
        public string TargetLanguage { get; set; } // english, german...
        public string SourceTranslation { get; set; } // text in source order
    }
}