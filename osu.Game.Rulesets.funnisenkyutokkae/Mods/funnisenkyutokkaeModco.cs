// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.funnisenkyutokkae.Replays;
using osu.Game.Rulesets.Mods;

namespace osu.Game.Rulesets.funnisenkyutokkae.Mods
{
    public class funnisenkyutokkaeModco : Mod
    {
        public override string Name => "Co";
        public override string Acronym => "CO";
        public override ModType Type => ModType.Conversion;
        //public override IconUsage? Icon => TauIcons.ModInverse;
        public override string Description => @"co";
        public override double ScoreMultiplier => 1;
        //public override Type[] IncompatibleMods => new[] { typeof(TauModHidden) };
    }
}
