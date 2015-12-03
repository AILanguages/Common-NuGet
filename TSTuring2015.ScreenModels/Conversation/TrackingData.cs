//-----------------------------------------------------------------------
// <copyright file="TrackingData.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.Conversation
{
    using System.Collections.Generic;

    public class TrackingData
    {
        public TrackingData()
        {
            SpokenList=new List<Dialog>();
        }

        public List<Dialog> SpokenList { get; set; }
    }
}