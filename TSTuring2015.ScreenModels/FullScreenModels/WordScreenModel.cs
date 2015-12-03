//-----------------------------------------------------------------------
// <copyright file="WordScreenModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.FullScreenModels
{
    public class WordScreenModel : FullScreenModel
    {
        public WordScreenModel()
        {
            CssScreen = "Word";
            ScreenName = "Word";
        }

        public string WordDetails { get; set; }
        public string WordForms { get; set; }
        public string Attributes { get; set; }
        public string Grammars { get; set; }
        public string Senses { get; set; }
    }
}