// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.funnisenkyutokkae.Replays;
using osu.Game.Rulesets.Mods;

namespace osu.Game.Rulesets.funnisenkyutokkae.Mods
{
    public class funnisenkyutokkaeModcheckmate : Modcheckmate
    {
        public override string Name => "checkmate";
        public override string Acronym => "CM";
        public override ModType Type => ModType.DifficultyReduction;
        //public override IconUsage? Icon => TauIcons.ModInverse;
        public override string Description => @"checknate";
        public override double ScoreMultiplier => 69;
        //public override Type[] IncompatibleMods => new[] { typeof(TauModHidden) };
    }
}
