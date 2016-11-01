using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class TrainableDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new TrainableDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private TrainableDefRenderer() { }

        public void Render(object target)
        {
            var result = target as TrainableDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(TrainableDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(TrainableDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(TrainableDef item)
        {
            CONS.WriteLine($"  {nameof(TrainableDef)}");
            CONS.WriteLine($"    defName: {item.DefName.ToStringOrDefault()}");
            CONS.WriteLine($"    label: {item.Label.ToStringOrDefault()}");
            CONS.WriteLine($"    description: {item.Description.ToStringOrDefault()}");
            CONS.WriteLine($"    icon: {item.Icon.ToStringOrDefault()}");
            if (item.Priority.HasValue)
            {
                CONS.WriteLine($"    listPriority: {item.Priority.Value}");
            }
            if (item.Difficulty.HasValue)
            {
                CONS.WriteLine($"    difficulty: {item.Difficulty.Value}");
            }
            if (item.MinBodySize.HasValue)
            {
                CONS.WriteLine($"    minBodySize: {item.MinBodySize.Value}");
            }
            if (item.RequiredTrainableIntelligence != null)
            {
                CONS.WriteLine($"    requiredTrainableIntelligence: {item.RequiredTrainableIntelligence}");
            }
            if (item.Steps.HasValue)
            {
                CONS.WriteLine($"    steps: {item.Steps.Value}");
            }
            if (item.DefaultTrainable.HasValue)
            {
                CONS.WriteLine($"    defaultTrainable: {item.DefaultTrainable.Value}");
            }
            if ((item.Prerequisites?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    prerequisites");
                foreach (var li in item.Prerequisites)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.Tags?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    tags");
                foreach (var li in item.Tags)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
        }
    }
}
