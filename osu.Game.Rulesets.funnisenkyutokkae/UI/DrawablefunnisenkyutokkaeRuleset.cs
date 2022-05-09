// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.funnisenkyutokkae.Objects;
using osu.Game.Rulesets.funnisenkyutokkae.Objects.Drawables;
using osu.Game.Rulesets.funnisenkyutokkae.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.funnisenkyutokkae.UI
{
    [Cached]
    public class DrawablefunnisenkyutokkaeRuleset : DrawableRuleset<funnisenkyutokkaeHitObject>
    {
        public DrawablefunnisenkyutokkaeRuleset(funnisenkyutokkaeRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
        }

        protected override Playfield CreatePlayfield() => new funnisenkyutokkaePlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new funnisenkyutokkaeFramedReplayInputHandler(replay);

        public override DrawableHitObject<funnisenkyutokkaeHitObject> CreateDrawableRepresentation(funnisenkyutokkaeHitObject h) => new DrawablefunnisenkyutokkaeHitObject(h);

        protected override PassThroughInputManager CreateInputManager() => new funnisenkyutokkaeInputManager(Ruleset?.RulesetInfo);
    }
}
