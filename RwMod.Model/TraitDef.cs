using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RwMod.Model
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class TraitDefs
    {
        [XmlElement(nameof(TraitDef), Form = XmlSchemaForm.Unqualified)]
        public TraitDef[] Items { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class TraitDef
    {
        [XmlElement("defName", Form = XmlSchemaForm.Unqualified)]
        public string DefName { get; set; }
        
        [XmlElement("commonality", Form = XmlSchemaForm.Unqualified)]
        public float Commonality { get; set; }

        [XmlElement("commonalityFemale", Form = XmlSchemaForm.Unqualified)]
        public float? CommonalityFemale { get; set; }

        [XmlArray("degreeDatas", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public DegreeDatum[] DegreeData { get; set; }

        [XmlArray("conflictingTraits", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] ConflictingTraits { get; set; }

        [XmlArray("requiredWorkTags", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] RequiredWorkTags { get; set; }

        [XmlArray("disabledWorkTags", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] DisabledWorkTags { get; set; }

        [XmlArray("requiredWorkTypes", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] RequiredWorkTypes { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class DegreeDatum
    {
        [XmlElement("label", Form = XmlSchemaForm.Unqualified)]
        public string Label { get; set; }

        [XmlElement("description", Form = XmlSchemaForm.Unqualified)]
        public string Description { get; set; }

        [XmlElement("degree", Form = XmlSchemaForm.Unqualified)]
        public float? Degree { get; set; }

        [XmlElement("socialFightChanceFactor", Form = XmlSchemaForm.Unqualified)]
        public float? SocialFightChanceFactor { get; set; }

        [XmlElement("statOffsets", Form = XmlSchemaForm.Unqualified)]
        public StatModifiers StatOffsets { get; set; }

        [XmlElement("statFactors", Form = XmlSchemaForm.Unqualified)]
        public StatModifiers StatFactors { get; set; }

        [XmlArray("skillGains", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public KeyedValue[] SkillGains { get; set; }

        [XmlArray("allowedMentalBreaks", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] AllowedMentalBreaks { get; set; }

        [XmlArray("disallowedMentalStates", Form = XmlSchemaForm.Unqualified)]
        [XmlArrayItem("li", Form = XmlSchemaForm.Unqualified)]
        public string[] DisallowedMentalStates { get; set; }

        [XmlElement("randomMentalState", Form = XmlSchemaForm.Unqualified)]
        public string RandomMentalState { get; set; }

        [XmlElement("randomMentalStateMtbDaysMoodCurve", Form = XmlSchemaForm.Unqualified)]
        public CurvePoints RandomMentalStateMtbDaysMoodCurve { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class StatModifiers
    {
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? GlobalLearningFactor { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? MentalBreakThreshold { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? MeleeHitChance { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? MoveSpeed { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? WorkSpeedGlobal { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? PsychicSensitivity { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? ComfyTemperatureMin { get; set; }
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? ComfyTemperatureMax { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? AimingDelayFactor { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public float? ShootingAccuracy { get; set; }
    }
}
