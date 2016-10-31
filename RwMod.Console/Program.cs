using RwMod.Console.Renderers;
using RwMod.Model;
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

            XmlTester<WeatherDefs> tester = new XmlTester<WeatherDefs>();
            IRenderer resultRenderer = WeatherDefRenderer.Instance;
            string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\WeatherDefs\Weathers.xml";

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
