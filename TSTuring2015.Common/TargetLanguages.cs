//-----------------------------------------------------------------------
// <copyright file="TargetLanguages.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Common
{
    public static class TargetLanguage
    {
        public static string GetAttribute(this TargetLanguages targetLanguage)
        {
            return targetLanguage.ToString().ToLower() + "-*-";
        }
    }

    public enum TargetLanguages
    {
        English,
        German,
        French,
        Latin,
        Indonesian,
        Spanish,
        Portuguese,
        Italian,
        Japanese,
        Mandarin,
        Cantonese,
        AfricanEnglish,
        Korean
    }
}