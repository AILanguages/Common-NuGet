//-----------------------------------------------------------------------
// <copyright file="AllLanguages.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Common
{
    using System;
    using System.Linq;

    public class AllLanguages
    {
        public static AllLanguageList[] GetArray()
        {
            return (AllLanguageList[])Enum.GetValues(typeof(AllLanguageList));
        }

        public static object[] LanguageObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }

    public enum AllLanguageList
    {
        OzEnglish, 
        USEnglish,
        UKEnglish,
        German,
        Korean, 
        Italian,
        Japanese, 
        Spanish,
        Portuguese, 
        Indonesian, 
        French, 
        Mandarin, 
        Cantonese
    }
}