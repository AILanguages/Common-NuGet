//-----------------------------------------------------------------------
// <copyright file="SampleMatchDisplay.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels
{
    using System.ComponentModel.DataAnnotations;

    public class Match
    {
        [Required(ErrorMessage = "A sentence is required")]
        [Display(Name = "Text to match")]
        public string TextIn { get; set; }
    }
}