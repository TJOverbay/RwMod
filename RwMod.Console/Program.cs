using RwMod.Model;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using CONS = System.Console;

namespace RwMod.Console
{
    public static class StringExtensions
    {
        public static string ToStringOrDefault(this string value, string defaultValue = "[null]")
        {
            if (string.IsNullOrWhiteSpace(value))
                return defaultValue;
            else
                return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\WorkTypeDefs\WorkTypes.xml";

            WorkTypeDefs result;
            if (DeserializeXml(pathToXmlFile, out result))
            {
                WriteWorkTypeDefsToConsole(result);
            }

            CONS.ReadLine();
        }

        private static void WriteWorkTypeDefsToConsole(WorkTypeDefs result)
        {
            CONS.Clear();
            CONS.WriteLine(nameof(WorkTypeDefs));

            foreach (var item in result.Items)
            {
                WriteItemToConsole(item);
            }
        }

        private static void WriteItemToConsole(WorkTypeDef item)
        {
            CONS.WriteLine($"  {nameof(WorkTypeDef)}");
            CONS.WriteLine($"    defName: {item.Name.ToStringOrDefault()}");
            CONS.WriteLine($"    labelShort: {item.ShortLabel.ToStringOrDefault()}");
            CONS.WriteLine($"    pawnLabel: {item.PawnLabel.ToStringOrDefault()}");
            CONS.WriteLine($"    gerundLabel: {item.GerundLabel.ToStringOrDefault()}");
            CONS.WriteLine($"    description: {item.Description.ToStringOrDefault()}");
            CONS.WriteLine($"    verb: {item.Verb.ToStringOrDefault()}");
            CONS.WriteLine($"    naturalPriority: {item.Priority}");
            CONS.WriteLine($"    alwaysStartActive: {item.AlwaysStartActive}");
            CONS.WriteLine($"    requireCapableColonist: {item.RequireCapableColonist}");
            if ((item.RelevantSkills?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    relevantSkills");
                foreach (var li in item.RelevantSkills)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
            if ((item.WorkTags?.Any()).GetValueOrDefault())
            {
                CONS.WriteLine($"    workTags");
                foreach (var li in item.WorkTags)
                {
                    CONS.WriteLine($"      li: {li.ToStringOrDefault()}");
                }
            }
        }

        private static bool DeserializeXml<T>(string pathToXmlFile, out T result)
        {
            result = default(T);

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (var reader = XmlReader.Create(pathToXmlFile, new XmlReaderSettings { ConformanceLevel = ConformanceLevel.Document, IgnoreProcessingInstructions = true }))
            {
                result = (T)serializer.Deserialize(reader);
            }

            return (result != null);
        }
    }
}
