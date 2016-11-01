using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "Defs", Namespace = "", IsNullable = false)]
    public class TradeDialogSorterDefs
    {
        [XmlElement(nameof(TradeDialogSorterDef), Form = XmlSchemaForm.Unqualified)]
        public TradeDialogSorterDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class TradeDialogSorterDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlElement("label", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("comparerClass", Form = XmlSchemaForm.Unqualified)]
        public string ComparerClass { get; set; }
    }
}
