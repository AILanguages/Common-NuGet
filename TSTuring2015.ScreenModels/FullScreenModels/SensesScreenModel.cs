//-----------------------------------------------------------------------
// <copyright file="SensesScreenModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.FullScreenModels
{
    using System.Collections.Generic;
    using PartDisplays;

    public class SensesScreenModel : FullScreenModel
    {
        public SensesScreenModel()
        {
            CssScreen = "Senses";
            ScreenName = "Senses";
            SenseList = new List<AbstractPartDisplay>();
        }

        public List<AbstractPartDisplay> SenseList { get; set; }
    }
}