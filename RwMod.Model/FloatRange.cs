using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class FloatRange
    {
        [XmlElement("min", Form = XmlSchemaForm.Unqualified)]
        public float Min { get; set; }
        [XmlElement("max", Form = XmlSchemaForm.Unqualified)]
        public float Max { get; set; }
    }
}