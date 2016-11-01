using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class IntRange
    {
        [XmlElement("min", Form = XmlSchemaForm.Unqualified)]
        public int Min { get; set; }
        [XmlElement("max", Form = XmlSchemaForm.Unqualified)]
        public int Max { get; set; }
    }
}