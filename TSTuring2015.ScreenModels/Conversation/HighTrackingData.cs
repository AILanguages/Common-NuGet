//-----------------------------------------------------------------------
// <copyright file="HighTrackingData.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.Conversation
{
    using System.Collections.Generic;

    public class HighTrackingData
    {
        public HighTrackingData()
        {
            HighContextList=new List<HighContext>();
        }

        public List<HighContext> HighContextList { get; set; }
    }
}