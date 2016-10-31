using RwMod.Model.Tutor;
using System;
using System.Linq;
using CONS = System.Console;

namespace RwMod.Console.Renderers
{
    internal class ConceptDefRenderer : IRenderer
    {
        private static readonly Lazy<IRenderer> _instance = new Lazy<IRenderer>(() => new ConceptDefRenderer());

        public static IRenderer Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private ConceptDefRenderer() { }

        public void Render(object target)
        {
            var result = target as ConceptDefs;
            if (result == null)
                throw new ArgumentException($"The specified item is not of type {nameof(ConceptDefs)}", nameof(target));

            CONS.Clear();
            CONS.WriteLine(nameof(ConceptDefs));

            if (result.Items != null)
            {
                foreach (var item in result.Items)
                {
                    WriteItemToConsole(item);
                }
            }

            if (result.Instructions != null)
            {
                foreach (var instr in result.Instructions)
                {
                    WriteInstructionToConsole(instr);
                }
            }
        }

        private static void WriteItemToConsole(ConceptDef item)
        {
            CONS.WriteLine($"  {nameof(ConceptDef)}");
            CONS.WriteLine($"    defName: {item.Name.ToStringOrDefault()}");
            CONS.WriteLine($"    label: {item.Label.ToStringOrDefault()}");
            if (item.Priority.HasValue)
            {
                CONS.WriteLine($"    priority: {item.Priority.Value}");
            }
            if (item.NeedsOpportunity.HasValue)
            {
                CONS.WriteLine($"    needsOpportunity: {item.NeedsOpportunity.Value}");
            }
            if (item.OpportunityDecays.HasValue)
            {
                CONS.WriteLine($"    opportunityDecays: {item.OpportunityDecays.Value}");
            }
            CONS.WriteLine($"    gameMode: {item.GameMode.ToStringOrDefault()}");
            CONS.WriteLine($"    helpText: {item.HelpText.ToStringOrDefault()}");
            if ((item.HighlightTags?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("    highlightTags");
                foreach (var li in item.HighlightTags)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
        }

        private void WriteInstructionToConsole(InstructionDef instr)
        {
            CONS.WriteLine($"  {nameof(InstructionDef)}");
            CONS.WriteLine($"    defName: {instr.Name.ToStringOrDefault()}");
            CONS.WriteLine($"    text: {instr.Text.ToStringOrDefault()}");
            CONS.WriteLine($"    instructionClass: {instr.InstructionClass.ToStringOrDefault()}");
            CONS.WriteLine($"    eventTagInitiate: {instr.EventTagInitiate.ToStringOrDefault()}");
            CONS.WriteLine($"    concept: {instr.Concept.ToStringOrDefault()}");
            CONS.WriteLine($"    thingDef: {instr.ThingDef.ToStringOrDefault()}");
            if (instr.TargetCount.HasValue)
            {
                CONS.WriteLine($"    targetCount: {instr.TargetCount.Value}");
            }
            CONS.WriteLine($"    recipeDef: {instr.RecipeDef.ToStringOrDefault()}");
            if (instr.RecipeTargetCount.HasValue)
            {
                CONS.WriteLine($"    recipeTargetCount: {instr.RecipeTargetCount.Value}");
            }
            CONS.WriteLine($"    giveOnActivateDef: {instr.GiveOnActivateDef.ToStringOrDefault()}");
            if (instr.GiveOnActivateCount.HasValue)
            {
                CONS.WriteLine($"    giveOnActivateCount: {instr.GiveOnActivateCount.Value}");
            }
            CONS.WriteLine($"    onMapInstruction: {instr.OnMapInstruction.ToStringOrDefault()}");
            if ((instr.ActionTagsAllowed?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("    actionTagsAllowed");
                foreach (var li in instr.ActionTagsAllowed)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((instr.EventTagsEnd?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("    eventTagsEnd");
                foreach (var li in instr.EventTagsEnd)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((instr.HighlightTags?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine("    highlightTags");
                foreach (var li in instr.HighlightTags)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            CONS.WriteLine($"    rejectInputMessage: {instr.RejectInputMessage.ToStringOrDefault()}");
            if (instr.StartCentered.HasValue)
            {
                CONS.WriteLine($"    startCentered: {instr.StartCentered.Value}");

            }
            if (instr.ResetBuildDesignatorStuffs.HasValue)
            {
                CONS.WriteLine($"    resetBuildDesignatorStuffs: {instr.ResetBuildDesignatorStuffs.Value}");

            }
            if (instr.EndTutorial.HasValue)
            {
                CONS.WriteLine($"    endTutorial: {instr.EndTutorial.Value}");

            }
        }
    }
}
