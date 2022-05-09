// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input.Bindings;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.funnisenkyutokkae.Beatmaps;
using osu.Game.Rulesets.funnisenkyutokkae.Mods;
using osu.Game.Rulesets.funnisenkyutokkae.UI;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.UI;
using osuTK;
using osuTK.Graphics;

namespace osu.Game.Rulesets.funnisenkyutokkae
{
    public class funnisenkyutokkaeRuleset : Ruleset
    {
        public override string Description => "funni senkyu tokkae ruleset";

        public override DrawableRuleset CreateDrawableRulesetWith(IBeatmap beatmap, IReadOnlyList<Mod> mods = null) =>
            new DrawablefunnisenkyutokkaeRuleset(this, beatmap, mods);

        public override IBeatmapConverter CreateBeatmapConverter(IBeatmap beatmap) =>
            new funnisenkyutokkaeBeatmapConverter(beatmap, this);

        public override DifficultyCalculator CreateDifficultyCalculator(IWorkingBeatmap beatmap) =>
            new funnisenkyutokkaeDifficultyCalculator(RulesetInfo, beatmap);

        public override IEnumerable<Mod> GetModsFor(ModType type)
        {
            switch (type)
            {
                case ModType.Automation:
                    return new[] { new funnisenkyutokkaeModAutoplay() };

                default:
                    return new Mod[] { null };
            }
        }

        public override string ShortName => "funnisenkyutokkaeruleset";

        public override IEnumerable<KeyBinding> GetDefaultKeyBindings(int variant = 0) => new[]
        {
            new KeyBinding(InputKey.Z, funnisenkyutokkaeAction.Button1),
            new KeyBinding(InputKey.X, funnisenkyutokkaeAction.Button2),
        };

        public override Drawable CreateIcon() => new Icon(ShortName[0]);
        protected override IEnumerable<HitResult> GetValidHitResults()
        {
            return new[]
            {
                HitResult.Great,
                HitResult.Good,
                HitResult.Meh
            };
        },

        public override string GetDisplayNameForHitResult(HitResult result) => result switch
        {
            HitResult.Great => "funni",
            HitResult.Good => "senkyu",
            HitResult.Meh => "tokkae",
            _ => base.GetDisplayNameForHitResult(result)
        };

        public class Icon : CompositeDrawable
        {
            public Icon(char c)
            {
                InternalChildren = new Drawable[]
                {
                    new Circle
                    {
                        Size = new Vector2(20),
                        Colour = Color4.White,
                    },
                    new SpriteText
                    {
                        Anchor = Anchor.Centre,
                        Origin = Anchor.Centre,
                        Text = c.ToString(),
                        Font = OsuFont.Default.With(size: 18)
                    }
                };
            }
        }
    }
}
