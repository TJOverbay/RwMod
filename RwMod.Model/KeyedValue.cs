using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class KeyedValue
    {
        [XmlElement("key", Form = XmlSchemaForm.Unqualified)]
        public string Key { get; set; }

        [XmlElement("value", Form = XmlSchemaForm.Unqualified)]
        public float Value { get; set; }
    }
}
