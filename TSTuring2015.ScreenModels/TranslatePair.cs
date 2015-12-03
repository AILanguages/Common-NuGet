//-----------------------------------------------------------------------
// <copyright file="TranslatePair.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels
{
    using System.ComponentModel.DataAnnotations;

    public class TranslatePair
    {
        [Required(ErrorMessage = "A sentence is required")]
        [Display(Name = "Matched pair - source and target")]
        public string Source { get; set; }
        public string Target { get; set; }        
    }
}