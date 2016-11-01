using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class WorkTypeDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new WorkTypeDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private WorkTypeDefRenderer() { }

        public void Render(object target)
        {
            var result = target as WorkTypeDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(WorkTypeDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(WorkTypeDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(WorkTypeDef item)
        {
            CONS.WriteLine($"  {nameof(WorkTypeDef)}");
            CONS.WriteLine($"    defName: {item.DefName.ToStringOrDefault()}");
            CONS.WriteLine($"    labelShort: {item.Label.ToStringOrDefault()}");
            CONS.WriteLine($"    pawnLabel: {item.PawnLabel.ToStringOrDefault()}");
            CONS.WriteLine($"    gerundLabel: {item.GerundLabel.ToStringOrDefault()}");
            CONS.WriteLine($"    description: {item.Description.ToStringOrDefault()}");
            CONS.WriteLine($"    verb: {item.Verb.ToStringOrDefault()}");
            CONS.WriteLine($"    naturalPriority: {item.Priority}");
            CONS.WriteLine($"    alwaysStartActive: {item.AlwaysStartActive}");
            CONS.WriteLine($"    requireCapableColonist: {item.RequireCapableColonist}");
            if ((item.RelevantSkills?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    relevantSkills");
                foreach (var li in item.RelevantSkills)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.WorkTags?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    workTags");
                foreach (var li in item.WorkTags)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
        }
    }
}
