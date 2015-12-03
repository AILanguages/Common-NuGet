//-----------------------------------------------------------------------
// <copyright file="BaseSettingsServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.CommonProxy
{
    using Common;
    using ScreenModels;

    public abstract class BaseSettingsServiceFacade
    {
        protected abstract void SetSampleFile(SampleFiles sampleFiles);
        protected abstract void SetSettings(MatchSettings settings);
        public abstract MatchSettings GetSettings();
        public abstract SampleSettings GetSampleSettings();

        public void UpdateSettings(MatchSettings matchSettings, SampleSettings sampleSettings)
        {
            // get settings from server to compare with new ones - avoid loss
            var oldsettings = GetSettings();
            var oldSamples = GetSampleSettings();

            if (matchSettings != null)
            {
                oldsettings.TargetLanguage = matchSettings.TargetLanguage;

                oldsettings.Speaker = matchSettings.Speaker;
                oldsettings.Characters = matchSettings.Characters;
                oldsettings.Formal = matchSettings.Formal;
                oldsettings.Polite = matchSettings.Polite;
                oldsettings.IllocutionaryForce = matchSettings.IllocutionaryForce;
                oldsettings.PersonChange = matchSettings.PersonChange;

                oldsettings.ShowSentences = matchSettings.ShowSentences;
                oldsettings.SimpleView = matchSettings.SimpleView;
            }

            if (sampleSettings != null)
            {
                oldSamples.SampleFiles = sampleSettings.SampleFiles;
            }

            SetSettings(oldsettings);
            SetSampleFile(oldSamples.SampleFiles);
        }
    }
}