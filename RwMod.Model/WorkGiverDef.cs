using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkGivers
    {
        [XmlElement(nameof(WorkGiverDef), Form = XmlSchemaForm.Unqualified)]
        public WorkGiverDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class WorkGiverDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlElement("label", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("giverClass", Form = XmlSchemaForm.Unqualified)]
        public string GiverClass { get; set; }

        [XmlElement("workType", Form = XmlSchemaForm.Unqualified)]
        public string WorkType { get; set; }

        [XmlElement("emergency", Form = XmlSchemaForm.Unqualified)]
        public bool? Emergency { get; set; }

        [XmlElement("verb", Form = XmlSchemaForm.Unqualified)]
        public string Verb { get; set; }

        [XmlElement("gerund", Form = XmlSchemaForm.Unqualified)]
        public string GerundLabel { get; set; }

        [XmlElement("priorityInType", Form = XmlSchemaForm.Unqualified)]
        public int? PriorityInType { get; set; }

        [XmlElement("prioritizeSustains", Form = XmlSchemaForm.Unqualified)]
        public bool? PrioritizeSustains { get; set; }

        [XmlElement("directOrderable", Form = XmlSchemaForm.Unqualified)]
        public bool? DirectOrderable { get; set; }

        [XmlElement("billGiversAllHumanlikes", Form = XmlSchemaForm.Unqualified)]
        public bool? BillGiversAllHumanlikes { get; set; }

        [XmlElement("billGiversAllHumanlikesCorpses", Form = XmlSchemaForm.Unqualified)]
        public bool? BillGiversAllHumanlikesCorpses { get; set; }

        [XmlElement("billGiversAllAnimals", Form = XmlSchemaForm.Unqualified)]
        public bool? BillGiversAllAnimals { get; set; }

        [XmlElement("billGiversAllAnimalsCorpses", Form = XmlSchemaForm.Unqualified)]
        public bool? BillGiversAllAnimalsCorpses { get; set; }

        [XmlElement("billGiversAllMechanoids", Form = XmlSchemaForm.Unqualified)]
        public bool? BillGiversAllMechanoids { get; set; }

        [XmlElement("billGiversAllMechanoidsCorpses", Form = XmlSchemaForm.Unqualified)]
        public bool? BillGiversAllMechanoidsCorpses { get; set; }

        [XmlElement("canBeDoneByNonColonists", Form = XmlSchemaForm.Unqualified)]
        public bool? CanBeDoneByNonColonists { get; set; }

        [XmlElement("scanThings", Form = XmlSchemaForm.Unqualified)]
        public bool? ScanThings { get; set; }

        [XmlElement("scanCells", Form = XmlSchemaForm.Unqualified)]
        public bool? ScanCells { get; set; }

        [XmlArray("requiredCapacities", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] RequiredCapacities { get; set; }

        [XmlArray("fixedBillGiverDefs", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] FixedBillGiverDefs { get; set; }
    }
}
