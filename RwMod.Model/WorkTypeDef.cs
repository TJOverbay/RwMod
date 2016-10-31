using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkTypeDefs
    {
        [XmlElement(nameof(WorkTypeDef), Form = XmlSchemaForm.Unqualified)]
        public WorkTypeDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class WorkTypeDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlElement("labelShort", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("pawnLabel", Form = XmlSchemaForm.Unqualified)]
        public string PawnLabel { get; set; }

        [XmlElement("gerundLabel", Form = XmlSchemaForm.Unqualified)]
        public string GerundLabel { get; set; }

        [XmlElement("description", Form = XmlSchemaForm.Unqualified)]
        public string Description { get; set; }

        [XmlElement("verb", Form = XmlSchemaForm.Unqualified)]
        public string Verb { get; set; }

        [XmlElement("naturalPriority", Form = XmlSchemaForm.Unqualified)]
        public float? Priority { get; set; }

        [XmlElement("alwaysStartActive", Form = XmlSchemaForm.Unqualified)]
        public bool? AlwaysStartActive { get; set; }

        [XmlElement("requireCapableColonist", Form = XmlSchemaForm.Unqualified)]
        public bool? RequireCapableColonist { get; set; }

        [XmlArray("workTags", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] WorkTags { get; set; }

        [XmlArray("relevantSkills", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] RelevantSkills { get; set; }
    }
}
