using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "DefPackage-TraderKindDef", Namespace = "", IsNullable = false)]
    public class TraderKindDefs
    {
        [XmlElement(nameof(TraderKindDef), Form = XmlSchemaForm.Unqualified)]
        public TraderKindDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class TraderKindDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string DefName { get; set; }

        [XmlElement("label", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("orbital", Form = XmlSchemaForm.Unqualified)]
        public bool? Orbital { get; set; }

        [XmlArray("stockGenerators", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public StockGenerator[] StockGenerators { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class StockGenerator
    {
        [XmlAttribute(Form = XmlSchemaForm.Unqualified)]
        public string Class { get; set; }

        [XmlElement("tradeTag", Form = XmlSchemaForm.Unqualified)]
        public string TradeTag { get; set; }

        [XmlElement("categoryDef", Form = XmlSchemaForm.Unqualified)]
        public string CategoryDef { get; set; }

        [XmlElement("thingDef", Form = XmlSchemaForm.Unqualified)]
        public string ThingDef { get; set; }

        [XmlElement("countRange", Form = XmlSchemaForm.Unqualified)]
        public IntRange CountRange { get; set; }

        [XmlElement("thingDefCountRange", Form = XmlSchemaForm.Unqualified)]
        public IntRange ThingDefCountRange { get; set; }

        [XmlElement("kindCountRange", Form = XmlSchemaForm.Unqualified)]
        public IntRange KindCountRange { get; set; }

        [XmlElement("price", Form = XmlSchemaForm.Unqualified)]
        public string Price { get; set; }

        [XmlElement("maxTechLevelGenerate", Form = XmlSchemaForm.Unqualified)]
        public string MaxTechLevelGenerate { get; set; }

        [XmlElement("totalPriceRange", Form = XmlSchemaForm.Unqualified)]
        public FloatRange TotalPriceRange { get; set; }

        [XmlElement("checkTemperature", Form = XmlSchemaForm.Unqualified)]
        public bool? CheckTemperature { get; set; }

        [XmlElement("maxWildness", Form = XmlSchemaForm.Unqualified)]
        public float? MaxWildness { get; set; }

        [XmlArray("tradeTags", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] TradeTags { get; set; }

        [XmlArray("thingDefs", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] ThingDefs { get; set; }
    }
}
