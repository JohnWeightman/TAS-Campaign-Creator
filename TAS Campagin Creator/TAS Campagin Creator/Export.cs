using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TAS_Campagin_Creator
{
    static class Export
    {
        static int TotalJobs = 0;
        static int CampaignJobs = 1;
        static int ModuleJobs = 0;
        static int Progress = 0;

        public static void ExportCampaign(Campaign Campaign)
        {
            CalculateJobs(Campaign);
            XmlWriter XML = XmlWriter.Create("Campaigns\\" + Campaign.Name + ".xml");
            XML.WriteStartDocument();
            XML.WriteStartElement(Campaign.Name);
            Progress += 1;
            for(int x = 0; x < Campaign.Modules.Count; x++)
            {
                XML.WriteStartElement(Campaign.Modules[x].Name);
                XML.WriteStartElement("Story");
                for(int y = 0; y < Campaign.Modules[x].Story.Count; y++)
                {
                    XML.WriteAttributeString("Part" + (y + 1), Campaign.Modules[x].Story[y]);
                }
                XML.WriteEndElement();
                XML.WriteStartElement("Options");
                for(int y = 0; y < Campaign.Modules[x].Options.OptionsList.Count; y++)
                {
                    XML.WriteAttributeString("Option" + (y + 1), Campaign.Modules[x].Options.OptionsList[y]);
                }
                XML.WriteEndElement();
                XML.WriteEndElement();
                Progress += 1;
            }
            XML.WriteEndElement();
            XML.WriteEndDocument();
            XML.Close();
        }

        static void CalculateJobs(Campaign Campaign)
        {
            ModuleJobs = Campaign.Modules.Count;
            TotalJobs = CampaignJobs + ModuleJobs;
        }
    }
}
