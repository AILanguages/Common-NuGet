//-----------------------------------------------------------------------
// <copyright file="AllGenders.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Common
{
    using System;
    using System.Linq;

    public class AllGenders
    {
        public static AllGendersList[] GetArray()
        {
            return (AllGendersList[])Enum.GetValues(typeof(AllGendersList));
        }

        public static object[] GenderObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }

    public enum AllGendersList
    {
        Male,
        Female, 
        Neuter
    }
}