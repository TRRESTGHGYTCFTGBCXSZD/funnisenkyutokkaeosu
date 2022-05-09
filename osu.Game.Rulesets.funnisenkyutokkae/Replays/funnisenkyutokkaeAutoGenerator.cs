// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.funnisenkyutokkae.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.funnisenkyutokkae.Replays
{
    public class funnisenkyutokkaeAutoGenerator : AutoGenerator<funnisenkyutokkaeReplayFrame>
    {
        public new Beatmap<funnisenkyutokkaeHitObject> Beatmap => (Beatmap<funnisenkyutokkaeHitObject>)base.Beatmap;

        public funnisenkyutokkaeAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void GenerateFrames()
        {
            Frames.Add(new funnisenkyutokkaeReplayFrame());

            foreach (funnisenkyutokkaeHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new funnisenkyutokkaeReplayFrame
                {
                    Time = hitObject.StartTime,
                    Position = hitObject.Position,
                    // todo: add required inputs and extra frames.
                });
            }
        }
    }
}
