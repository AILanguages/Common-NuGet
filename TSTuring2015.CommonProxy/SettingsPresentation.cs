﻿//-----------------------------------------------------------------------
// <copyright file="SettingsPresentation.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using ScreenModels;

    public class SettingsPresentation
    {
        public MatchSettings Settings { get; set; }
        public bool SettingsChanged { get; set; }
    }
}
