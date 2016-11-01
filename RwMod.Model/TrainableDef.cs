using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "Defs", Namespace = "", IsNullable = false)]
    public class TrainableDefs
    {
        [XmlElement(nameof(TrainableDef), Form = XmlSchemaForm.Unqualified)]
        public TrainableDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class TrainableDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlElement("label", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("description", Form = XmlSchemaForm.Unqualified)]
        public string Description { get; set; }

        [XmlElement("icon", Form = XmlSchemaForm.Unqualified)]
        public string Icon { get; set; }

        [XmlElement("listPriority", Form = XmlSchemaForm.Unqualified)]
        public float? Priority { get; set; }

        [XmlElement("difficulty", Form = XmlSchemaForm.Unqualified)]
        public float? Difficulty { get; set; }

        [XmlElement("minBodySize", Form = XmlSchemaForm.Unqualified)]
        public float? MinBodySize { get; set; }

        [XmlElement("requiredTrainableIntelligence", Form = XmlSchemaForm.Unqualified)]
        public string RequiredTrainableIntelligence { get; set; }

        [XmlElement("steps", Form = XmlSchemaForm.Unqualified)]
        public int? Steps { get; set; }

        [XmlElement("defaultTrainable", Form = XmlSchemaForm.Unqualified)]
        public bool? DefaultTrainable { get; set; }

        [XmlArray("prerequisites", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] Prerequisites { get; set; }

        [XmlArray("tags", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] Tags { get; set; }
    }
}
