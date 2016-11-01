using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "ThinkTrees", Namespace = "", IsNullable = false)]
    public class ThinkTreeDefs
    {
        [XmlElement(nameof(ThinkTreeDef), Form = XmlSchemaForm.Unqualified)]
        public ThinkTreeDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class ThinkTreeDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string DefName { get; set; }

        [XmlElement("thinkRoot", Form = XmlSchemaForm.Unqualified)]
        public ThinkNode ThinkRoot { get; set; }
    }

    public class ThinkNode
    {
        [XmlAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Class { get; set; }

        [XmlElement("treeDef", Form = XmlSchemaForm.Unqualified)]
        public string TreeDef { get; set; }

        [XmlElement("invert", Form = XmlSchemaForm.Unqualified)]
        public bool? Invert { get; set; }

        [XmlElement("min", Form = XmlSchemaForm.Unqualified)]
        public float? Min { get; set; }

        [XmlElement("defaultLocomotion", Form = XmlSchemaForm.Unqualified)]
        public string DefaultLocomotion { get; set; }

        [XmlElement("locomotionUrgency", Form = XmlSchemaForm.Unqualified)]
        public string LocomotionUrgency { get; set; }

        [XmlElement("forceCanDig", Form = XmlSchemaForm.Unqualified)]
        public bool? ForceCanDig { get; set; }

        [XmlElement("canBash", Form = XmlSchemaForm.Unqualified)]
        public bool? CanBash { get; set; }

        [XmlElement("state", Form = XmlSchemaForm.Unqualified)]
        public string State { get; set; }

        [XmlArray("states", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] States { get; set; }

        [XmlElement("insertTag", Form = XmlSchemaForm.Unqualified)]
        public string InsertTag { get; set; }

        [XmlElement("need", Form = XmlSchemaForm.Unqualified)]
        public string Need { get; set; }

        [XmlElement("minPriority", Form = XmlSchemaForm.Unqualified)]
        public float? MinPriority { get; set; }

        [XmlElement("threshold", Form = XmlSchemaForm.Unqualified)]
        public float? Threshold { get; set; }

        [XmlElement("dutyHook", Form = XmlSchemaForm.Unqualified)]
        public string DutyHook { get; set; }

        [XmlElement("tagToGive", Form = XmlSchemaForm.Unqualified)]
        public string TagToGive { get; set; }

        [XmlElement("leaveJoinableLordIfIssuesJob", Form = XmlSchemaForm.Unqualified)]
        public bool? LeaveJoinableLordIfIssuesJob { get; set; }

        [XmlElement("emergency", Form = XmlSchemaForm.Unqualified)]
        public bool? Emergency { get; set; }

        [XmlElement("trainable", Form = XmlSchemaForm.Unqualified)]
        public string Trainable { get; set; }

        [XmlElement("radius", Form = XmlSchemaForm.Unqualified)]
        public float? Radius { get; set; }

        [XmlElement("mtbHours", Form = XmlSchemaForm.Unqualified)]
        public float? MtbHours { get; set; }

        [XmlElement("maxDanger", Form = XmlSchemaForm.Unqualified)]
        public string MaxDanger { get; set; }

        [XmlElement("ticksBetweenWandersRange", Form = XmlSchemaForm.Unqualified)]
        public IntRange TicksBetweenWandersRange { get; set; }

        [XmlArray("subNodes", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public ThinkNode[] SubNodes { get; set; }
    }
}
