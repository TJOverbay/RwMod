using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class TraderKindDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new TraderKindDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private TraderKindDefRenderer() { }

        public void Render(object target)
        {
            var result = target as TraderKindDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(TraderKindDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(TraderKindDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(TraderKindDef item)
        {
            CONS.WriteLine($"  {nameof(TraderKindDef)}");
            CONS.WriteLine($"    defName: {item.DefName.ToStringOrDefault()}");
            CONS.WriteLine($"    label: {item.Label.ToStringOrDefault()}");
            if (item.Orbital.HasValue)
            {
                CONS.WriteLine($"    orbital: {item.Orbital.Value}");
            }
            if ((item.StockGenerators?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("    stockGenerators");
                foreach (var li in item.StockGenerators)
                {
                    RenderStockGenerator(li);
                }
            }
        }

        private static void RenderStockGenerator(StockGenerator gen)
        {
            CONS.WriteLine($"      Class: {gen.Class.ToStringOrDefault()}");
            if (gen.TradeTag != null)
            {
                CONS.WriteLine($"      tradeTag: {gen.TradeTag}");
            }
            if ((gen.TradeTags?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("      tradeTags:");
                foreach (var tag in gen.TradeTags)
                {
                    CONS.WriteLine($"        li: {tag.ToStringOrDefault()}");
                }
            }
            if (gen.CategoryDef != null)
            {
                CONS.WriteLine($"      categoryDef: {gen.CategoryDef}");
            }
            if (gen.ThingDef != null)
            {
                CONS.WriteLine($"      thingDef: {gen.ThingDef}");
            }
            if ((gen.ThingDefs?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("      thingDefs:");
                foreach (var def in gen.ThingDefs)
                {
                    CONS.WriteLine($"        li: {def.ToStringOrDefault()}");
                }
            }
            if (gen.CountRange != null)
            {
                CONS.WriteLine($"      countRange: {gen.CountRange.ToRenderString()}");
            }
            if (gen.ThingDefCountRange != null)
            {
                CONS.WriteLine($"      thingDefCountRange: {gen.ThingDefCountRange.ToRenderString()}");
            }
            if (gen.KindCountRange != null)
            {
                CONS.WriteLine($"      kindCountRange: {gen.KindCountRange.ToRenderString()}");
            }
            if (gen.Price != null)
            {
                CONS.WriteLine($"      price: {gen.Price}");
            }
            if (gen.TotalPriceRange != null)
            {
                CONS.WriteLine($"      totalPriceRange: {gen.TotalPriceRange.ToRenderString()}");
            }
            if (gen.MaxTechLevelGenerate != null)
            {
                CONS.WriteLine($"      maxTechLevelGenerate: {gen.MaxTechLevelGenerate}");
            }
            if (gen.CheckTemperature.HasValue)
            {
                CONS.WriteLine($"      checkTemperature: {gen.CheckTemperature.Value}");
            }
            if (gen.MaxWildness.HasValue)
            {
                CONS.WriteLine($"      maxWildness: {gen.MaxWildness.Value}");
            }
        }
    }
}
