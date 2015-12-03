//-----------------------------------------------------------------------
// <copyright file="ConversationalItems.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels.Conversation
{
    using System;

    public static class ConversationalItems
    {
        internal static string GetCurrentTime()
        {
            var time = DateTime.Now;
            return time.ToString("HH:mm d MMM");
        }
    }
}
