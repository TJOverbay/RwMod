using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "Defs", Namespace = "", IsNullable = false)]
    public class ThoughtDefs
    {
        [XmlElement(nameof(ThoughtDef), Form = XmlSchemaForm.Unqualified)]
        public ThoughtDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class ThoughtDef
    {
        [XmlAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlAttribute(Form = XmlSchemaForm.Unqualified)]
        public string AbstractString { get; set; }

        [XmlIgnore]
        public bool? Abstract
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(AbstractString))
                {
                    return string.Equals("true", AbstractString, StringComparison.InvariantCultureIgnoreCase);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                AbstractString = value.ToString();
            }
        }

        [XmlAttribute(Form = XmlSchemaForm.Unqualified)]
        public string ParentName { get; set; }

        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string DefName { get; set; }

        [XmlElement("workerClass", Form = XmlSchemaForm.Unqualified)]
        public string WorkerClass { get; set; }

        [XmlElement("thoughtClass", Form = XmlSchemaForm.Unqualified)]
        public string ThoughtClass { get; set; }

        [XmlElement("hediff", Form = XmlSchemaForm.Unqualified)]
        public string Hediff { get; set; }

        [XmlElement("taleDef", Form = XmlSchemaForm.Unqualified)]
        public string TaleDef { get; set; }

        [XmlElement("validWhileInMentalState", Form = XmlSchemaForm.Unqualified)]
        public bool? ValidWhileInMentalState { get; set; }

        [XmlElement("nullifiedIfNotColonist", Form = XmlSchemaForm.Unqualified)]
        public bool? NullifiedIfNotColonist { get; set; }

        [XmlElement("invert", Form = XmlSchemaForm.Unqualified)]
        public bool? Invert { get; set; }

        [XmlElement("durationDays", Form = XmlSchemaForm.Unqualified)]
        public float? DurationDays { get; set; }

        [XmlElement("stackLimit", Form = XmlSchemaForm.Unqualified)]
        public int? StackLimit { get; set; }

        [XmlElement("stackLimitPerPawn", Form = XmlSchemaForm.Unqualified)]
        public int? StackLimitPerPawn { get; set; }

        [XmlElement("maxCumulatedOpinionOffset", Form = XmlSchemaForm.Unqualified)]
        public float? MaxCumulatedOpinionOffset { get; set; }

        [XmlElement("stackedEffectMultiplier", Form = XmlSchemaForm.Unqualified)]
        public float? StackedEffectMultiplier { get; set; }

        [XmlElement("effectMultiplyingStat", Form = XmlSchemaForm.Unqualified)]
        public string EffectMultiplyingStat { get; set; }

        [XmlElement("nextThought", Form = XmlSchemaForm.Unqualified)]
        public string NextThought { get; set; }

        [XmlElement("thoughtToMake", Form = XmlSchemaForm.Unqualified)]
        public string ThoughtToMake { get; set; }

        [XmlArray("requiredTraits", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] RequiredTraits { get; set; }

        [XmlElement("requiredTraitsDegree", Form = XmlSchemaForm.Unqualified)]
        public int? RequiredTraitsDegree { get; set; }

        [XmlArray("nullifyingTraits", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] NullifyingTraits { get; set; }

        [XmlArray("nullifyingOwnTales", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] NullifyingOwnTales { get; set; }

        [XmlArray("stages", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public ThoughtStage[] Stages { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class ThoughtStage
    {
        [XmlElement("label", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("labelSocial", Form = XmlSchemaForm.Unqualified)]
        public string LabelSocial { get; set; }

        [XmlElement("description", Form = XmlSchemaForm.Unqualified)]
        public string Description { get; set; }

        [XmlElement("baseMoodEffect", Form = XmlSchemaForm.Unqualified)]
        public int? BaseMoodEffect { get; set; }

        [XmlElement("baseOpinionOffset", Form = XmlSchemaForm.Unqualified)]
        public float? BaseOpinionOffset { get; set; }
    }
}
