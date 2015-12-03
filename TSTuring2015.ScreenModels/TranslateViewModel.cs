//-----------------------------------------------------------------------
// <copyright file="TranslateViewModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class TranslateViewModel
    {
        public TranslateViewModel()
        {
            Reset();
        }

        private void Reset()
        {
            Translations = new List<TranslatePair>();
        }

        [Display(Name = "Translate source")]
        public string LastSearch { get; set; }

        public Match Match { get; set; }

        public MatchSettings MatchSettings { get; set; }
        public SampleSettings SampleSettings { get; set; }

        public List<TranslatePair> Translations { get; set; }
    }
}