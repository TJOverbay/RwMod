using RwMod.Console.Renderers;
using RwMod.Model;
using RwMod.Model.Tutor;
using System.Xml;
using System.Xml.Serialization;
using CONS = System.Console;

namespace RwMod.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlTester<WorkTypeDefs> tester = new XmlTester<WorkTypeDefs>();
            //IRenderer resultRenderer = WorkTypeDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\WorkTypeDefs\WorkTypes.xml";

            //XmlTester<WorkGiverDefs> tester = new XmlTester<WorkGiverDefs>();
            //IRenderer resultRenderer = WorkGiverDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\WorkGiverDefs\WorkGivers.xml";

            //XmlTester<WeatherDefs> tester = new XmlTester<WeatherDefs>();
            //IRenderer resultRenderer = WeatherDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\WeatherDefs\Weathers.xml";

            //XmlTester<ConceptDefs> tester = new XmlTester<ConceptDefs>();
            //IRenderer resultRenderer = ConceptDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\Tutor\Concepts_Entry.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\Tutor\Concepts_NotedOpportunistic.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\Tutor\Concepts_NotedSelfshow.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\Tutor\Concepts_TriggeredModal.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\Tutor\Instructions.xml";

            //XmlTester<TraitDefs> tester = new XmlTester<TraitDefs>();
            //IRenderer resultRenderer = TraitDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TraitDefs\Traits_Singular.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TraitDefs\Traits_Spectrum.xml";

            XmlTester<TrainableDefs> tester = new XmlTester<TrainableDefs>();
            IRenderer resultRenderer = TrainableDefRenderer.Instance;
            string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TrainableDefs\Trainables.xml";

            tester.TestXmlFile(pathToXmlFile, resultRenderer);

            CONS.ReadLine();
        }
    }

    class XmlTester<T>
    {
        public void TestXmlFile(string pathToXmlFile, IRenderer resultRenderer)
        {
            T result;

            if (DeserializeXml(pathToXmlFile, out result))
            {
                resultRenderer.Render(result);
            }
        }

        private static bool DeserializeXml(string pathToXmlFile, out T result)
        {
            result = default(T);

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            var settings = new XmlReaderSettings
            {
                ConformanceLevel = ConformanceLevel.Document,
                IgnoreProcessingInstructions = true,
                IgnoreComments = true,
            };

            using (var reader = XmlReader.Create(pathToXmlFile, settings))
            {
                result = (T)serializer.Deserialize(reader);
            }

            return (result != null);
        }
    }

    public interface IRenderer
    {
        void Render(object item);
    }

}
