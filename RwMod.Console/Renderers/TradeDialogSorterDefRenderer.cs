using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class TradeDialogSorterDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new TradeDialogSorterDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private TradeDialogSorterDefRenderer() { }

        public void Render(object target)
        {
            var result = target as TradeDialogSorterDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(TradeDialogSorterDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(TradeDialogSorterDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(TradeDialogSorterDef item)
        {
            CONS.WriteLine($"  {nameof(TradeDialogSorterDef)}");
            CONS.WriteLine($"    defName: {item.Name.ToStringOrDefault()}");
            CONS.WriteLine($"    label: {item.Label.ToStringOrDefault()}");
            CONS.WriteLine($"    comparerClass: {item.ComparerClass.ToStringOrDefault()}");
        }
    }
}
