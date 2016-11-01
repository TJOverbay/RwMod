using RwMod.Console.Renderers;
using RwMod.Model;
using RwMod.Model.Tutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using CONS = System.Console;

namespace RwMod.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootElement = null;

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

            //XmlTester<TrainableDefs> tester = new XmlTester<TrainableDefs>();
            //IRenderer resultRenderer = TrainableDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TrainableDefs\Trainables.xml";

            //XmlTester<TraderKindDefs> tester = new XmlTester<TraderKindDefs>();
            //IRenderer resultRenderer = TraderKindDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TraderKindDefs\TraderKinds_Caravan_Neolithic.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TraderKindDefs\TraderKinds_Caravan_Outlander.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TraderKindDefs\TraderKinds_Orbital_Misc.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TraderKindDefs\TraderKinds_Visitor_Neolithic.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TraderKindDefs\TraderKinds_Visitor_Outlander.xml";

            //XmlTester<TradeDialogSorterDefs> tester = new XmlTester<TradeDialogSorterDefs>();
            //IRenderer resultRenderer = TradeDialogSorterDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TradeDialogSorterDefs\TradeDialogSorters.xml";

            //XmlTester<TimeAssignmentDefs> tester = new XmlTester<TimeAssignmentDefs>();
            //IRenderer resultRenderer = TimeAssignmentDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\TimeAssignmentDefs\TimeAssignments.xml";

            IRenderer resultRenderer = ThoughtDefRenderer.Instance;
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Exotic.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Memory_Debug.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Memory_Eating.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Memory_Gatherings.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Random.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Situation_Needs.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Situation_RoomStats.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Situation_Traits.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Situation_TraitsPerm.xml";

            //rootElement = "ThoughtDefs"; // Uncomment this line for the following XML files
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Memory_Death.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Memory_Misc.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Memory_Social.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Situation_Social.xml";
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Situation_Special.xml";

            //rootElement = "Thoughts";     // Uncomment this line for the following XML files
            //string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Situation_General.xml";

            rootElement = "GameData";     // Uncomment this line for the following XML files
            string pathToXmlFile = @"D:\Users\Tim\SteamLibrary\steamapps\common\RimWorld\Mods\Core\Defs\ThoughtDefs\Thoughts_Situation_MentalState.xml";

            XmlTester<ThoughtDefs> tester = new XmlTester<ThoughtDefs>(rootElement);

            tester.TestXmlFile(pathToXmlFile, resultRenderer);

            CONS.ReadLine();
        }
    }

    class XmlTester<T>
    {
        private readonly string _rootElement;

        public XmlTester()
        {
            _rootElement = null;
        }

        public XmlTester(string rootElement)
        {
            _rootElement = rootElement;
        }

        public void TestXmlFile(string pathToXmlFile, IRenderer resultRenderer)
        {
            T result;

            if (DeserializeXml(pathToXmlFile, _rootElement, out result))
            {
                resultRenderer.Render(result);
            }
        }

        private static bool DeserializeXml(string pathToXmlFile, string rootElement, out T result)
        {
            result = default(T);
            XmlSerializer serializer;

            if (string.IsNullOrWhiteSpace(rootElement))
            {
                serializer = new XmlSerializer(typeof(T));
            }
            else
            {
                serializer = new XmlSerializer(typeof(T),
                    new XmlRootAttribute
                    {
                        ElementName = rootElement,
                        Namespace = ""
                    });
            }

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
