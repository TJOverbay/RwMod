using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class TimeAssignmentDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new TimeAssignmentDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private TimeAssignmentDefRenderer() { }

        public void Render(object target)
        {
            var result = target as TimeAssignmentDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(TimeAssignmentDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(TimeAssignmentDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(TimeAssignmentDef item)
        {
            CONS.WriteLine($"  {nameof(TimeAssignmentDef)}");
            CONS.WriteLine($"    defName: {item.Name.ToStringOrDefault()}");
            CONS.WriteLine($"    label: {item.Label.ToStringOrDefault()}");
            CONS.WriteLine($"    color: {item.Color.ToStringOrDefault()}");
            if (item.AllowRest.HasValue)
            {
                CONS.WriteLine($"    allowRest: {item.AllowRest.Value}");
            }
            if (item.AllowJoy.HasValue)
            {
                CONS.WriteLine($"    allowJoy: {item.AllowJoy.Value}");
            }
        }
    }
}
