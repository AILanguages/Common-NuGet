//-----------------------------------------------------------------------
// <copyright file="PronounContext.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.Conversation
{
    using System.Collections.Generic;

    public class PronounContext
    {
        public List<string> ClausePart { get; set; }
        public List<string> ClauseElements { get; set; }
        public string LS { get; set; }
        public string Clause { get; set; }
        public List<string> Information { get; set; }
    }
}