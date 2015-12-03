//-----------------------------------------------------------------------
// <copyright file="Formality.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Common
{
    using System;
    using System.Linq;

    public class AllFormalList
    {
        public static Formalities[] GetArray()
        {
            return (Formalities[])Enum.GetValues(typeof(Formalities));
        }

        public static object[] FormalObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }

    public enum Formalities
    {
        VeryHigh,
        High,
        Neutral,
        Low
    }
}