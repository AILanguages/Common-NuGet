//-----------------------------------------------------------------------
// <copyright file="PersonChange.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Common
{
    using System;
    using System.Linq;

    public class AllPersonChangeList
    {
        public static PersonChange[] GetArray()
        {
            return (PersonChange[])Enum.GetValues(typeof(PersonChange));
        }

        public static object[] PersonChangeObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }

    public enum PersonChange
    {
        Source,
        OneToOne1PSg,
        OneToMany2PPl,
        WithMe1PPl
    }
}