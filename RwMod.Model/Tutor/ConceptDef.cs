using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model.Tutor
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "Defs", Namespace = "", IsNullable = false)]
    public class ConceptDefs
    {
        [XmlElement(nameof(ConceptDef), Form = XmlSchemaForm.Unqualified)]
        public ConceptDef[] Items { get; set; }
        [XmlElement(nameof(InstructionDef), Form = XmlSchemaForm.Unqualified)]
        public InstructionDef[] Instructions { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class ConceptDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlElement("label", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("priority", Form = XmlSchemaForm.Unqualified)]
        public float? Priority { get; set; }

        [XmlElement("needsOpportunity", Form = XmlSchemaForm.Unqualified)]
        public string NeedsOpportunityString { get; set; }

        [XmlIgnore]
        public bool? NeedsOpportunity
        {
            get
            {
                if (NeedsOpportunityString != null)
                {
                    return string.Equals("true", NeedsOpportunityString, StringComparison.InvariantCultureIgnoreCase);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value.HasValue)
                {
                    NeedsOpportunityString = value.Value.ToString();
                }
                else
                {
                    NeedsOpportunityString = null;
                }
            }
        }

        [XmlElement("opportunityDecays", Form = XmlSchemaForm.Unqualified)]
        public bool? OpportunityDecays { get; set; }

        [XmlElement("gameMode", Form = XmlSchemaForm.Unqualified)]
        public string GameMode { get; set; }

        [XmlElement("helpText", Form = XmlSchemaForm.Unqualified)]
        public string HelpText { get; set; }

        [XmlArray("highlightTags", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] HighlightTags { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class InstructionDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlElement("text", Form = XmlSchemaForm.Unqualified)]
        public string Text { get; set; }

        [XmlElement("eventTagInitiate", Form = XmlSchemaForm.Unqualified)]
        public string EventTagInitiate { get; set; }

        [XmlElement("instructionClass", Form = XmlSchemaForm.Unqualified)]
        public string InstructionClass { get; set; }

        [XmlElement("concept", Form = XmlSchemaForm.Unqualified)]
        public string Concept { get; set; }

        [XmlElement("thingDef", Form = XmlSchemaForm.Unqualified)]
        public string ThingDef { get; set; }

        [XmlElement("targetCount", Form = XmlSchemaForm.Unqualified)]
        public int? TargetCount { get; set; }

        [XmlElement("recipeDef", Form = XmlSchemaForm.Unqualified)]
        public string RecipeDef { get; set; }

        [XmlElement("recipeTargetCount", Form = XmlSchemaForm.Unqualified)]
        public int? RecipeTargetCount { get; set; }

        [XmlElement("giveOnActivateDef", Form = XmlSchemaForm.Unqualified)]
        public string GiveOnActivateDef { get; set; }

        [XmlElement("giveOnActivateCount", Form = XmlSchemaForm.Unqualified)]
        public int? GiveOnActivateCount { get; set; }

        [XmlArray("actionTagsAllowed", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] ActionTagsAllowed { get; set; }

        [XmlElement("onMapInstruction", Form = XmlSchemaForm.Unqualified)]
        public string OnMapInstruction { get; set; }

        [XmlArray("eventTagsEnd", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] EventTagsEnd { get; set; }

        [XmlArray("highlightTags", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] HighlightTags { get; set; }

        [XmlElement("rejectInputMessage", Form = XmlSchemaForm.Unqualified)]
        public string RejectInputMessage { get; set; }

        [XmlElement("startCentered", Form = XmlSchemaForm.Unqualified)]
        public bool? StartCentered { get; set; }

        [XmlElement("resetBuildDesignatorStuffs", Form = XmlSchemaForm.Unqualified)]
        public bool? ResetBuildDesignatorStuffs { get; set; }

        [XmlElement("endTutorial", Form = XmlSchemaForm.Unqualified)]
        public bool? EndTutorial { get; set; }
    }
}
