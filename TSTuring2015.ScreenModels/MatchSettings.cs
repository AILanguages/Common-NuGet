//-----------------------------------------------------------------------
// <copyright file="MatchSettings.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ScreenModels
{
    using Common;

    public class MatchSettings
    {
        public MatchSettings()
        {
            ShowSentences = false;
            SimpleView = true;
            TargetLanguage = TargetLanguages.English;
            Formal = Formalities.Neutral;
            Polite = Politeness.Neutral;
            Speaker = RelativePositions.WorkersToWorkers;
            IllocutionaryForce = IllocutionaryForce.Source;
            PersonChange = PersonChange.Source;
            Characters = Display.Letters;
        }

        public Match Edit { get; set; }
        public Match Last { get; set; }

        public TargetLanguages TargetLanguage { get; set; }
        public bool ShowSentences { get; set; }
        public bool SimpleView { get; set; }
        public Display Characters { get; set; }
        public Formalities Formal { get; set; }
        public Politeness Polite { get; set; }
        public RelativePositions Speaker { get; set; }
        public PersonChange PersonChange { get; set; }
        public IllocutionaryForce IllocutionaryForce { get; set; }
    }
}