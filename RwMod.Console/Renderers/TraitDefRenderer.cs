using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class TraitDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new TraitDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private TraitDefRenderer() { }

        public void Render(object target)
        {
            var result = target as TraitDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(TraitDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(TraitDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(TraitDef item)
        {
            CONS.WriteLine($"  {nameof(TraitDef)}");
            CONS.WriteLine($"    defName: {item.Name.ToStringOrDefault()}");
            CONS.WriteLine($"    commonality: {item.Commonality}");
            if (item.CommonalityFemale.HasValue)
            {
                CONS.WriteLine($"    commonalityFemale: {item.CommonalityFemale.Value}");
            }
            if ((item.DegreeData?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    degreeDatas");
                foreach (var datum in item.DegreeData)
                {
                    RenderDegreeDatum(datum);
                }
            }
            if ((item.ConflictingTraits?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    conflictingTraits");
                foreach (var li in item.ConflictingTraits)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.RequiredWorkTags?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    requiredWorkTags");
                foreach (var li in item.RequiredWorkTags)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.RequiredWorkTypes?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    requiredWorkTypes");
                foreach (var li in item.RequiredWorkTypes)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.DisabledWorkTags?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    disabledWorkTags");
                foreach (var li in item.DisabledWorkTags)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
        }

        private static void RenderDegreeDatum(DegreeDatum datum)
        {
            CONS.WriteLine($"      label: {datum.Label.ToStringOrDefault()}");
            CONS.WriteLine($"      description: {datum.Description.ToStringOrDefault()}");
            if (datum.Degree.HasValue)
            {
                CONS.WriteLine($"      degree: {datum.Degree.Value}");
            }
            if (datum.SocialFightChanceFactor.HasValue)
            {
                CONS.WriteLine($"      socialFightChanceFactor: {datum.SocialFightChanceFactor.Value}");
            }
            if (datum.StatOffsets != null)
            {
                CONS.WriteLine("      statOffsets");
                RenderStatModifiers(datum.StatOffsets);
            }
            if (datum.StatFactors != null)
            {
                CONS.WriteLine("      statFactors");
                RenderStatModifiers(datum.StatFactors);
            }
            if ((datum.SkillGains?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("      skillGains");
                foreach (var kv in datum.SkillGains)
                {
                    CONS.WriteLine($"        li: {kv.ToRenderString()}");
                }
            }
            if ((datum.AllowedMentalBreaks?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"      allowedMentalBreaks");
                foreach (var li in datum.AllowedMentalBreaks)
                {
                    CONS.WriteLine($"        li: {li.ToStringOrDefault()}");
                }
            }
            if ((datum.DisallowedMentalStates?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"      disallowedMentalStates");
                foreach (var li in datum.DisallowedMentalStates)
                {
                    CONS.WriteLine($"        li: {li.ToStringOrDefault()}");
                }
            }
            if (datum.RandomMentalState != null)
            {
                CONS.WriteLine($"      randomMentalState: {datum.RandomMentalState}");
            }

            RenderMoodCurve(datum.RandomMentalStateMtbDaysMoodCurve);
        }

        private static void RenderStatModifiers(StatModifiers stats)
        {
            if (stats.GlobalLearningFactor.HasValue)
            {
                CONS.WriteLine($"        GlobalLearningFactor: {stats.GlobalLearningFactor.Value}");
            }
            if (stats.MentalBreakThreshold.HasValue)
            {
                CONS.WriteLine($"        MentalBreakThreshold: {stats.MentalBreakThreshold.Value}");
            }
            if (stats.MeleeHitChance.HasValue)
            {
                CONS.WriteLine($"        MeleeHitChance: {stats.MeleeHitChance.Value}");
            }
            if (stats.MoveSpeed.HasValue)
            {
                CONS.WriteLine($"        MoveSpeed: {stats.MoveSpeed.Value}");
            }
            if (stats.WorkSpeedGlobal.HasValue)
            {
                CONS.WriteLine($"        WorkSpeedGlobal: {stats.WorkSpeedGlobal.Value}");
            }
            if (stats.PsychicSensitivity.HasValue)
            {
                CONS.WriteLine($"        PsychicSensitivity: {stats.PsychicSensitivity.Value}");
            }
            if (stats.ComfyTemperatureMin.HasValue)
            {
                CONS.WriteLine($"        ComfyTemperatureMin: {stats.ComfyTemperatureMin.Value}");
            }
            if (stats.ComfyTemperatureMax.HasValue)
            {
                CONS.WriteLine($"        ComfyTemperatureMax: {stats.ComfyTemperatureMax.Value}");
            }
            if (stats.AimingDelayFactor.HasValue)
            {
                CONS.WriteLine($"        AimingDelayFactor: {stats.AimingDelayFactor.Value}");
            }
            if (stats.ShootingAccuracy.HasValue)
            {
                CONS.WriteLine($"        ShootingAccuracy: {stats.ShootingAccuracy.Value}");
            }
        }

        private static void RenderMoodCurve(CurvePoints curve)
        {
            if ((curve?.Points.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"      randomMentalStateMtbDaysMoodCurve");
                foreach (var li in curve.Points)
                {
                    CONS.WriteLine($"        li: {li.ToStringOrDefault()}");
                }
            }
        }

    }
}
