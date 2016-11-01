using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class ThoughtDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new ThoughtDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private ThoughtDefRenderer() { }

        public void Render(object target)
        {
            var result = target as ThoughtDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(ThoughtDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(ThoughtDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(ThoughtDef item)
        {
            CONS.WriteLine($"  {nameof(ThoughtDef)}");
            CONS.WriteLine($"    defName: {item.DefName.ToStringOrDefault()}");
            if (item.Name != null)
            {
                CONS.WriteLine($"    Name: {item.Name.ToStringOrDefault()}");
            }
            if (item.Abstract.HasValue)
            {
                CONS.WriteLine($"    Abstract: {item.Abstract.Value}");
            }
            if (item.ParentName != null)
            {
                CONS.WriteLine($"    ParentName: {item.ParentName.ToStringOrDefault()}");
            }
            if (item.WorkerClass != null)
            {
                CONS.WriteLine($"    workerClass: {item.WorkerClass.ToStringOrDefault()}");
            }
            if (item.ThoughtClass != null)
            {
                CONS.WriteLine($"    thoughtClass: {item.ThoughtClass.ToStringOrDefault()}");
            }
            if (item.Hediff != null)
            {
                CONS.WriteLine($"    hediff: {item.Hediff.ToStringOrDefault()}");
            }
            if (item.TaleDef != null)
            {
                CONS.WriteLine($"    taleDef: {item.TaleDef.ToStringOrDefault()}");
            }
            if (item.ValidWhileInMentalState.HasValue)
            {
                CONS.WriteLine($"    validWhileInMentalState: {item.ValidWhileInMentalState.Value}");
            }
            if (item.NullifiedIfNotColonist.HasValue)
            {
                CONS.WriteLine($"    nullifiedIfNotColonist: {item.NullifiedIfNotColonist.Value}");
            }
            if (item.Invert.HasValue)
            {
                CONS.WriteLine($"    invert: {item.Invert.Value}");
            }
            if (item.DurationDays.HasValue)
            {
                CONS.WriteLine($"    durationDays: {item.DurationDays.Value}");
            }
            if (item.StackLimit.HasValue)
            {
                CONS.WriteLine($"    stackLimit: {item.StackLimit.Value}");
            }
            if (item.StackLimitPerPawn.HasValue)
            {
                CONS.WriteLine($"    stackLimitPerPawn: {item.StackLimitPerPawn.Value}");
            }
            if (item.MaxCumulatedOpinionOffset.HasValue)
            {
                CONS.WriteLine($"    maxCumulatedOpinionOffset: {item.MaxCumulatedOpinionOffset.Value}");
            }
            if (item.StackedEffectMultiplier.HasValue)
            {
                CONS.WriteLine($"    stackedEffectMultiplier: {item.StackedEffectMultiplier.Value}");
            }
            if (item.EffectMultiplyingStat != null)
            {
                CONS.WriteLine($"    effectMultiplyingStat: {item.EffectMultiplyingStat.ToStringOrDefault()}");
            }
            if (item.NextThought != null)
            {
                CONS.WriteLine($"    nextThought: {item.NextThought.ToStringOrDefault()}");
            }
            if (item.ThoughtToMake != null)
            {
                CONS.WriteLine($"    thoughtToMake: {item.ThoughtToMake.ToStringOrDefault()}");
            }
            if ((item.RequiredTraits?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    requiredTraits");
                foreach (var li in item.RequiredTraits)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if (item.RequiredTraitsDegree.HasValue)
            {
                CONS.WriteLine($"    requiredTraitsDegree: {item.RequiredTraitsDegree.Value}");
            }
            if ((item.NullifyingTraits?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    nullifyingTraits");
                foreach (var li in item.NullifyingTraits)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.NullifyingOwnTales?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    nullifyingOwnTales");
                foreach (var li in item.NullifyingOwnTales)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.Stages?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    stages");
                foreach (var stg in item.Stages)
                {
                    RenderThoughtStage(stg);
                }
            }
        }

        private static void RenderThoughtStage(ThoughtStage stg)
        {
            CONS.WriteLine("      li");
            CONS.WriteLine($"        label: {stg.Label.ToStringOrDefault()}");
            if (stg.LabelSocial != null)
            {
                CONS.WriteLine($"        labelSocial: {stg.LabelSocial.ToStringOrDefault()}");
            }
            CONS.WriteLine($"        description: {stg.Description.ToStringOrDefault()}");
            if (stg.BaseMoodEffect.HasValue)
            {
                CONS.WriteLine($"        baseMoodEffect: {stg.BaseMoodEffect.Value}");
            }
            if (stg.BaseOpinionOffset.HasValue)
            {
                CONS.WriteLine($"        baseOpinionOffset: {stg.BaseOpinionOffset.Value}");
            }
        }
    }
}
