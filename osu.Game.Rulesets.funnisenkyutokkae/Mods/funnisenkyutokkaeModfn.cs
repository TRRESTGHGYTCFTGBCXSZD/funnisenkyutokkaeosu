// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.funnisenkyutokkae.Replays;
using osu.Game.Rulesets.Mods;

namespace osu.Game.Rulesets.funnisenkyutokkae.Mods
{
    public class funnisenkyutokkaeModfn : Mod
    {
        public override string Name => "Fn";
        public override string Acronym => "FN";
        public override ModType Type => ModType.Fun;
        //public override IconUsage? Icon => TauIcons.ModInverse;
        public override string Description => @"fn";
        public override double ScoreMultiplier => 1;
        //public override Type[] IncompatibleMods => new[] { typeof(TauModHidden) };
    }
}
