//-----------------------------------------------------------------------
// <copyright file="PronounTrackingData.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.Conversation
{
    using System.Collections.Generic;

    public class PronounTrackingData
    {
        public PronounTrackingData()
        {
            PronounList=new List<PronounContext>();
        }

        public List<PronounContext> PronounList { get; set; }
    }
}