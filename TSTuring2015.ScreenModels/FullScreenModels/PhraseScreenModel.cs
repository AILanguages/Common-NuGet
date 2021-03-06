﻿//-----------------------------------------------------------------------
// <copyright file="PhraseScreenModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.FullScreenModels
{
    using System.Collections.Generic;
    using PartDisplays;

    public class PhraseScreenModel : FullScreenModel
    {
        public PhraseScreenModel()
        {
            Top = new TopScreenModel();
            PhraseList = new List<AbstractPartDisplay>();
        }

        public TopScreenModel Top { get; set; }
        public List<AbstractPartDisplay> PhraseList { get; set; }
    }
}