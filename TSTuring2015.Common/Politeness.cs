//-----------------------------------------------------------------------
// <copyright file="Politeness.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Common
{
    using System;
    using System.Linq;

    public class AllPoliteList
    {
        public static Politeness[] GetArray()
        {
            return (Politeness[])Enum.GetValues(typeof(Politeness));
        }

        public static object[] FormalObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }
    public enum Politeness
    {
        VeryHigh,
        High,
        Neutral,
        Low
    }
}