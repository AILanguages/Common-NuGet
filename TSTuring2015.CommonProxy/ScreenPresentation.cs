//-----------------------------------------------------------------------
// <copyright file="ScreenPresentation.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using ScreenModels.FullScreenModels;

    public class ScreenPresentation
    {
        public FullScreenModel ScreenModel { get; set; }
        public string ScreenName { get; set; }
        public bool ScreenFound { get; set; }
        public bool SimpleView { get; set; }
    }
}
