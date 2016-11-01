using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WeatherDefs
    {
        [XmlElement(nameof(WeatherDef), Form = XmlSchemaForm.Unqualified)]
        public WeatherDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class WeatherDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlElement("label", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("description", Form = XmlSchemaForm.Unqualified)]
        public string Description { get; set; }

        [XmlElement("repeatable", Form = XmlSchemaForm.Unqualified)]
        public bool? Repeatable { get; set; }

        [XmlElement("windSpeedFactor", Form = XmlSchemaForm.Unqualified)]
        public float? WindSpeedFactor { get; set; }

        [XmlElement("accuracyMultiplier", Form = XmlSchemaForm.Unqualified)]
        public float? AccuracyMultiplier { get; set; }

        [XmlElement("favorability", Form = XmlSchemaForm.Unqualified)]
        public string Favorability { get; set; }

        [XmlElement("rainRate", Form = XmlSchemaForm.Unqualified)]
        public float? RainRate { get; set; }

        [XmlElement("snowRate", Form = XmlSchemaForm.Unqualified)]
        public float? SnowRate { get; set; }

        [XmlElement("moveSpeedMultiplier", Form = XmlSchemaForm.Unqualified)]
        public float? MoveSpeedMultiplier { get; set; }

        [XmlElement("skyColorsDay", Form = XmlSchemaForm.Unqualified)]
        public SkyColors SkyColorsDay { get; set; }

        [XmlElement("skyColorsDusk", Form = XmlSchemaForm.Unqualified)]
        public SkyColors SkyColorsDusk { get; set; }

        [XmlElement("skyColorsNightEdge", Form = XmlSchemaForm.Unqualified)]
        public SkyColors SkyColorsNightEdge { get; set; }

        [XmlElement("skyColorsNightMid", Form = XmlSchemaForm.Unqualified)]
        public SkyColors SkyColorsNightMid { get; set; }

        [XmlElement("commonalityRainfallFactor", Form = XmlSchemaForm.Unqualified)]
        public CurvePoints CommonalityRainfallFactor { get; set; }

        [XmlElement("temperatureRange", Form = XmlSchemaForm.Unqualified)]
        public FloatRange TemperatureRange { get; set; }

        [XmlElement("durationRange", Form = XmlSchemaForm.Unqualified)]
        public FloatRange DurationRange { get; set; }

        [XmlArray("ambientSounds", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] AmbientSounds { get; set; }

        [XmlArray("overlayClasses", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] OverlayClasses { get; set; }

        [XmlArray("eventMakers", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public EventMaker[] EventMakers { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class EventMaker
    {
        [XmlElement("averageInterval", Form = XmlSchemaForm.Unqualified)]
        public int? AverageInterval { get; set; }
        [XmlElement("eventClass", Form = XmlSchemaForm.Unqualified)]
        public string EventClass { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class SkyColors
    {
        [XmlElement("sky", Form = XmlSchemaForm.Unqualified)]
        public string Sky { get; set; }
        [XmlElement("shadow", Form = XmlSchemaForm.Unqualified)]
        public string Shadow { get; set; }
        [XmlElement("overlay", Form = XmlSchemaForm.Unqualified)]
        public string Overlay { get; set; }
        [XmlElement("saturation", Form = XmlSchemaForm.Unqualified)]
        public float? Saturation { get; set; }
    }
}
