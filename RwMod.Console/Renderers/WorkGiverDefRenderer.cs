using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class WorkGiverDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new WorkGiverDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private WorkGiverDefRenderer() { }

        public void Render(object target)
        {
            var result = target as WorkGiverDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(WorkGiverDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(WorkGiverDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(WorkGiverDef item)
        {
            CONS.WriteLine($"  {nameof(WorkGiverDef)}");
            CONS.WriteLine($"    defName: {item.Name.ToStringOrDefault()}");
            CONS.WriteLine($"    label: {item.Label.ToStringOrDefault()}");
            CONS.WriteLine($"    giverClass: {item.GiverClass.ToStringOrDefault()}");
            CONS.WriteLine($"    workType: {item.WorkType.ToStringOrDefault()}");
            if (item.Emergency.HasValue)
            {
                CONS.WriteLine($"    emergency: {item.Emergency.Value}");
            }
            CONS.WriteLine($"    verb: {item.Verb.ToStringOrDefault()}");
            CONS.WriteLine($"    gerund: {item.GerundLabel.ToStringOrDefault()}");
            CONS.WriteLine($"    priorityInType: {item.PriorityInType}");
            if (item.PrioritizeSustains.HasValue)
            {
                CONS.WriteLine($"    prioritizeSustains: {item.PrioritizeSustains.Value}");
            }
            if (item.DirectOrderable.HasValue)
            {
                CONS.WriteLine($"    directOrderable: {item.DirectOrderable.Value}");
            }
            if (item.BillGiversAllHumanlikes.HasValue)
            {
                CONS.WriteLine($"    billGiversAllHumanlikes: {item.BillGiversAllHumanlikes.Value}");
            }
            if (item.BillGiversAllHumanlikesCorpses.HasValue)
            {
                CONS.WriteLine($"    billGiversAllHumanlikesCorpses: {item.BillGiversAllHumanlikesCorpses.Value}");
            }
            if (item.BillGiversAllAnimals.HasValue)
            {
                CONS.WriteLine($"    billGiversAllAnimals: {item.BillGiversAllAnimals.Value}");
            }
            if (item.BillGiversAllAnimalsCorpses.HasValue)
            {
                CONS.WriteLine($"    billGiversAllAnimalsCorpses: {item.BillGiversAllAnimalsCorpses.Value}");
            }
            if (item.BillGiversAllMechanoids.HasValue)
            {
                CONS.WriteLine($"    billGiversAllMechanoids: {item.BillGiversAllMechanoids.Value}");
            }
            if (item.BillGiversAllMechanoidsCorpses.HasValue)
            {
                CONS.WriteLine($"    billGiversAllMechanoidsCorpses: {item.BillGiversAllMechanoidsCorpses.Value}");
            }
            if (item.CanBeDoneByNonColonists.HasValue)
            {
                CONS.WriteLine($"    canBeDoneByNonColonists: {item.CanBeDoneByNonColonists.Value}");
            }
            if (item.ScanThings.HasValue)
            {
                CONS.WriteLine($"    scanThings: {item.ScanThings.Value}");
            }
            if (item.ScanCells.HasValue)
            {
                CONS.WriteLine($"    scanCells: {item.ScanCells.Value}");
            }

            if ((item.RequiredCapacities?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    requiredCapacities");
                foreach (var li in item.RequiredCapacities)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.FixedBillGiverDefs?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    fixedBillGiverDefs");
                foreach (var li in item.FixedBillGiverDefs)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
        }
    }
}
