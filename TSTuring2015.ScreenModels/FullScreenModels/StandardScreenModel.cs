//-----------------------------------------------------------------------
// <copyright file="StandardScreenModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.FullScreenModels
{
    using System.Collections.Generic;
    using PartDisplays;

    public class StandardScreenModel : FullScreenModel
    {
        public StandardScreenModel()
        {
            Top = new TopScreenModel();
            Main = new List<SenseListModel>();
            MainList = new List<AbstractPartDisplay>();
        }

        public TopScreenModel Top { get; set; }
        public List<SenseListModel> Main { get; set; }
        public List<AbstractPartDisplay> MainList { get; set; }
    }
}