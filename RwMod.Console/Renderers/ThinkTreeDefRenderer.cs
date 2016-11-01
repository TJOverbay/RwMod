using RwMod.Model;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class ThinkTreeDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new ThinkTreeDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private ThinkTreeDefRenderer() { }

        public void Render(object target)
        {
            var result = target as ThinkTreeDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(ThinkTreeDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(ThinkTreeDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(ThinkTreeDef item)
        {
            CONS.WriteLine($"  {nameof(ThinkTreeDef)}");
            CONS.WriteLine($"    defName: {item.DefName.ToStringOrDefault()}");
            CONS.WriteLine("    thinkRoot");
            RenderThinkNode(item.ThinkRoot);
        }

        private static void RenderThinkNode(ThinkNode node, int indentLevel = 3)
        {
            if (node == null) return;
            var indent = new string(' ', indentLevel * 2);
            CONS.WriteLine($"{indent}li");
            CONS.WriteLine($"{indent}  Class: {node.Class.ToStringOrDefault()}");
            if (node.TreeDef != null)
            {
                CONS.WriteLine($"{indent}  treeDef: {node.TreeDef.ToStringOrDefault()}");
            }
            if (node.Invert.HasValue)
            {
                CONS.WriteLine($"{indent}  invert: {node.Invert.Value}");
            }
            if (node.Min.HasValue)
            {
                CONS.WriteLine($"{indent}  min: {node.Min.Value}");
            }
            if (node.DefaultLocomotion != null)
            {
                CONS.WriteLine($"{indent}  defaultLocomotion: {node.DefaultLocomotion.ToStringOrDefault()}");
            }
            if (node.LocomotionUrgency != null)
            {
                CONS.WriteLine($"{indent}  locomotionUrgency: {node.LocomotionUrgency.ToStringOrDefault()}");
            }
            if (node.ForceCanDig.HasValue)
            {
                CONS.WriteLine($"{indent}  forceCanDig: {node.ForceCanDig.Value}");
            }
            if (node.CanBash.HasValue)
            {
                CONS.WriteLine($"{indent}  canBash: {node.CanBash.Value}");
            }
            if (node.State != null)
            {
                CONS.WriteLine($"{indent}  state: {node.State.ToStringOrDefault()}");
            }
            if ((node.States?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"{indent}  states");
                foreach (var li in node.States)
                {
                    CONS.WriteLine($"{indent}  li: {li.ToStringOrDefault()}");
                }
            }
            if (node.InsertTag != null)
            {
                CONS.WriteLine($"{indent}  insertTag: {node.InsertTag.ToStringOrDefault()}");
            }
            if (node.Need != null)
            {
                CONS.WriteLine($"{indent}  need: {node.Need.ToStringOrDefault()}");
            }
            if (node.MinPriority.HasValue)
            {
                CONS.WriteLine($"{indent}  minPriority: {node.MinPriority.Value}");
            }
            if (node.Threshold.HasValue)
            {
                CONS.WriteLine($"{indent}  threshold: {node.Threshold.Value}");
            }
            if (node.DutyHook != null)
            {
                CONS.WriteLine($"{indent}  dutyHook: {node.DutyHook.ToStringOrDefault()}");
            }
            if (node.TagToGive != null)
            {
                CONS.WriteLine($"{indent}  tagToGive: {node.TagToGive.ToStringOrDefault()}");
            }
            if (node.LeaveJoinableLordIfIssuesJob.HasValue)
            {
                CONS.WriteLine($"{indent}  leaveJoinableLordIfIssuesJob: {node.LeaveJoinableLordIfIssuesJob.Value}");
            }
            if (node.Emergency.HasValue)
            {
                CONS.WriteLine($"{indent}  emergency: {node.Emergency.Value}");
            }
            if (node.Trainable != null)
            {
                CONS.WriteLine($"{indent}  trainable: {node.Trainable.ToStringOrDefault()}");
            }
            if (node.Radius.HasValue)
            {
                CONS.WriteLine($"{indent}  radius: {node.Radius.Value}");
            }
            if (node.MtbHours.HasValue)
            {
                CONS.WriteLine($"{indent}  mtbHours: {node.MtbHours.Value}");
            }
            if (node.MaxDanger != null)
            {
                CONS.WriteLine($"{indent}  maxDanger: {node.MaxDanger.ToStringOrDefault()}");
            }
            if (node.TicksBetweenWandersRange != null)
            {
                CONS.WriteLine($"{indent}  ticksBetweenWandersRange: {node.TicksBetweenWandersRange.ToRenderString()}");
            }
            if ((node.SubNodes?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"{indent}  subNodes");
                foreach (var li in node.SubNodes)
                {
                    RenderThinkNode(li, indentLevel + 2);
                }
            }
        }
    }
}
