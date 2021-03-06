﻿//-----------------------------------------------------------------------
// <copyright file="FullClauseScreenModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.FullScreenModels
{
    using System.Collections.Generic;
    using PartDisplays;

    public class FullClauseScreenModel : FullScreenModel
    {
        public FullClauseScreenModel()
        {
            Top = new TopScreenModel();
            Main = new List<SenseListModel>();
            MainList = new List<AbstractPartDisplay>();

            ScreenName = "Clause";
            Nucleus = new SenseListModel();
            Nucleus2 = new SenseListModel();
            NucleusPrep = new SenseListModel();
            ClauseCoreList = new List<AbstractPartDisplay>();
            ClauseNuclearList = new List<AbstractPartDisplay>();

            CoreOperators = new TextListPartDisplay { Title = "Operators" };
            CoreAttributes = new TextListPartDisplay { Title = "Attributes" };

            NucleusOperators = new TextListPartDisplay { Title = "Operators" };
            NucleusAttributes = new TextListPartDisplay { Title = "Attributes" };

            NextClause = new List<FullClauseScreenModel>();
        }

        public TopScreenModel Top { get; set; }
        public List<SenseListModel> Main { get; set; }
        public List<AbstractPartDisplay> MainList { get; set; }

        public SenseListModel Nucleus { get; set; }
        public SenseListModel Nucleus2 { get; set; }
        public SenseListModel NucleusPrep { get; set; }
        public List<AbstractPartDisplay> ClauseCoreList { get; set; }
        public List<AbstractPartDisplay> ClauseNuclearList { get; set; }

        public TextListPartDisplay NucleusOperators { get; set; }
        public TextListPartDisplay NucleusAttributes { get; set; }
        public TextListPartDisplay CoreAttributes { get; set; }
        public TextListPartDisplay CoreOperators { get; set; }

        public List<FullClauseScreenModel> NextClause { get; set; }

        public int Part { get; set; }
    }
}