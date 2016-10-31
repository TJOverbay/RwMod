using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class WeatherDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new WeatherDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private WeatherDefRenderer() { }

        public void Render(object target)
        {
            var result = target as WeatherDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(WeatherDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(WeatherDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(WeatherDef item)
        {
            CONS.WriteLine($"  {nameof(WeatherDef)}");
            CONS.WriteLine($"    defName: {item.Name.ToStringOrDefault()}");
            CONS.WriteLine($"    label: {item.Label.ToStringOrDefault()}");
            CONS.WriteLine($"    description: {item.Description.ToStringOrDefault()}");
            if (item.Repeatable.HasValue)
            {
                CONS.WriteLine($"    repeatable: {item.Repeatable.Value}");
            }
            if (item.WindSpeedFactor.HasValue)
            {
                CONS.WriteLine($"    windSpeedFactor: {item.WindSpeedFactor.Value}");
            }
            if (item.AccuracyMultiplier.HasValue)
            {
                CONS.WriteLine($"    accuracyMultiplier: {item.AccuracyMultiplier.Value}");
            }
            CONS.WriteLine($"    favorability: {item.Favorability.ToStringOrDefault()}");
            if (item.RainRate.HasValue)
            {
                CONS.WriteLine($"    rainRate: {item.RainRate.Value}");
            }
            if (item.SnowRate.HasValue)
            {
                CONS.WriteLine($"    snowRate: {item.SnowRate.Value}");
            }
            if (item.MoveSpeedMultiplier.HasValue)
            {
                CONS.WriteLine($"    moveSpeedMultiplier: {item.MoveSpeedMultiplier.Value}");
            }
            if (item.CommonalityRainfallFactor != null)
            {
                CONS.WriteLine("    commonalityRainfallFactor");
                RenderRainFallFactors(item.CommonalityRainfallFactor);
            }
            if (item.TemperatureRange != null)
            {
                CONS.WriteLine("    temperatureRange");
                CONS.WriteLine($"      {item.TemperatureRange.ToRenderString()}");
            }
            if (item.DurationRange != null)
            {
                CONS.WriteLine("    durationRange");
                CONS.WriteLine($"      {item.DurationRange.ToRenderString()}");
            }
            if ((item.AmbientSounds?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("    ambientSounds");
                foreach (var li in item.AmbientSounds)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.OverlayClasses?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("    overlayClasses");
                foreach (var li in item.OverlayClasses)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.EventMakers?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("    eventMakers");
                foreach (var li in item.EventMakers)
                {
                    CONS.WriteLine("      li");
                    if (li.AverageInterval.HasValue)
                    {
                        CONS.WriteLine($"        averageInterval: {li.AverageInterval.Value}");
                    }
                    CONS.WriteLine($"        eventClass: {li.EventClass.ToStringOrDefault()}");
                }
            }
            if ((item.SkyColorsDay != null))
            {
                CONS.WriteLine("    skyColorsDay");
                RenderSkyColors(item.SkyColorsDay);
            }
            if ((item.SkyColorsDusk != null))
            {
                CONS.WriteLine("    skyColorsDusk");
                RenderSkyColors(item.SkyColorsDusk);
            }
            if ((item.SkyColorsNightEdge != null))
            {
                CONS.WriteLine("    skyColorsNightEdge");
                RenderSkyColors(item.SkyColorsNightEdge);
            }
            if ((item.SkyColorsNightMid != null))
            {
                CONS.WriteLine("    skyColorsNightMid");
                RenderSkyColors(item.SkyColorsNightMid);
            }
        }

        private static void RenderRainFallFactors(RainfallFactors factors)
        {
            if ((factors?.Points.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"      points");
                foreach (var li in factors.Points)
                {
                    CONS.WriteLine($"          li: {li.ToStringOrDefault()}");
                }
            }
        }

        private static void RenderSkyColors(SkyColors colors)
        {
            CONS.WriteLine($"      sky: {colors.Sky.ToStringOrDefault()}");
            CONS.WriteLine($"      shadow: {colors.Shadow.ToStringOrDefault()}");
            CONS.WriteLine($"      overlay: {colors.Overlay.ToStringOrDefault()}");
            CONS.WriteLine($"      saturation: {colors.Saturation.GetValueOrDefault()}");
        }
    }
}
