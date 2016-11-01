using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "Defs", Namespace = "", IsNullable = false)]
    public class TimeAssignmentDefs
    {
        [XmlElement(nameof(TimeAssignmentDef), Form = XmlSchemaForm.Unqualified)]
        public TimeAssignmentDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class TimeAssignmentDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string DefName { get; set; }

        [XmlElement("label", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("color", Form = XmlSchemaForm.Unqualified)]
        public string Color { get; set; }

        [XmlElement("allowRest", Form = XmlSchemaForm.Unqualified)]
        public bool? AllowRest { get; set; }

        [XmlElement("allowJoy", Form = XmlSchemaForm.Unqualified)]
        public bool? AllowJoy { get; set; }
    }
}
