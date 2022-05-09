// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;
using osuTK;

namespace osu.Game.Rulesets.funnisenkyutokkae.Replays
{
    public class funnisenkyutokkaeReplayFrame : ReplayFrame
    {
        public List<funnisenkyutokkaeAction> Actions = new List<funnisenkyutokkaeAction>();
        public Vector2 Position;

        public funnisenkyutokkaeReplayFrame(funnisenkyutokkaeAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
