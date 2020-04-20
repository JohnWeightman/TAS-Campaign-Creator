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
        static Progress Pro = new Progress();

        static int TotalJobs = 0;
        static int CampaignJobs = 1;
        static int ModuleJobs = 0;
        static int OptionJobs = 0;
        static int Progress = 0;

        public static void ExportCampaign()
        {
            CalculateJobs();
            Pro.Show();
            Pro.InitiliaseProgressBar(TotalJobs);
            XmlWriter XML = XmlWriter.Create("Campaigns\\" + Storage.Campaign.Name + ".xml");
            XML.WriteStartDocument();
            WriteCampaignData(XML);
            XML.WriteEndDocument();
            XML.Close();
            Pro.Close();
            ResetExport();
        }

        static void WriteCampaignData(XmlWriter XML)
        {
            XML.WriteStartElement(Storage.Campaign.Name);
            for(int ModNum = 0; ModNum < Storage.Campaign.Modules.Count; ModNum++)
            {
                WriteModuleData(XML, ModNum);
            }
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("Module");
            XML.WriteAttributeString("Name", Storage.Campaign.Modules[ModNum].Name);
            XML.WriteAttributeString("ModType", Convert.ToString(Storage.Campaign.Modules[ModNum].ModType));
            WriteModuleStoryData(XML, ModNum);
            WriteModuleOptionData(XML, ModNum);
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleStoryData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("Story");
            for(int x = 0; x < Storage.Campaign.Modules[ModNum].Story.Count; x++)
                XML.WriteAttributeString("Part" + (x + 1), Storage.Campaign.Modules[ModNum].Story[x]);
            XML.WriteEndElement();
        }

        static void WriteModuleOptionData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("Options");
            WriteModuleOptionListData(XML, ModNum);
            WriteModuleOptionDirectionData(XML, ModNum);
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleOptionListData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("OptionsList");
            for (int x = 0; x < Storage.Campaign.Modules[ModNum].Options.OptionsList.Count; x++)
            {
                XML.WriteAttributeString("Option" + (x + 1), Storage.Campaign.Modules[ModNum].Options.OptionsList[x]);
            }
            XML.WriteEndElement();
        }

        static void WriteModuleOptionDirectionData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("OptionDirections");
            for (int x = 0; x < Storage.Campaign.Modules[ModNum].Options.OptionDirections.Count; x++)
            {
                XML.WriteAttributeString("OptionDirection" + (x + 1), Convert.ToString(Storage.Campaign.Modules[ModNum].Options.OptionDirections[x]));
            }
            XML.WriteEndElement();
        }

        static void CalculateJobs()
        {
            ModuleJobs = Storage.Campaign.Modules.Count;
            foreach (Module Mod in Storage.Campaign.Modules)
                OptionJobs += Mod.Options.OptionsList.Count + Mod.Options.OptionDirections.Count;
            TotalJobs = CampaignJobs + ModuleJobs + OptionJobs;
        }

        static void ResetExport()
        {
            TotalJobs = 0;
            CampaignJobs = 1;
            ModuleJobs = 0;
            OptionJobs = 0;
            Progress = 0;
        }

        //public static void ExportCampaign(Campaign Campaign)
        //{
        //    CalculateJobs(Campaign);
        //    Pro.Show();
        //    Pro.InitiliaseProgressBar(TotalJobs);
        //    XmlWriter XML = XmlWriter.Create("Campaigns\\" + Campaign.Name + ".xml");
        //    XML.WriteStartDocument();
        //    XML.WriteStartElement(Campaign.Name);
        //    Progress += 1;
        //    Pro.UpdateProgress(Progress);
        //    for (int x = 0; x < Campaign.Modules.Count; x++)
        //    {
        //        XML.WriteStartElement("Module");
        //        XML.WriteAttributeString("Name", Campaign.Modules[x].Name);
        //        XML.WriteAttributeString("ModType", Convert.ToString(Campaign.Modules[x].ModType));
        //        XML.WriteStartElement("Story");
        //        for (int y = 0; y < Campaign.Modules[x].Story.Count; y++)
        //        {
        //            XML.WriteAttributeString("Part" + (y + 1), Campaign.Modules[x].Story[y]);
        //        }
        //        XML.WriteEndElement();
        //        XML.WriteStartElement("Options");
        //        XML.WriteStartElement("OptionsList");
        //        for (int y = 0; y < Campaign.Modules[x].Options.OptionsList.Count; y++)
        //        {
        //            XML.WriteAttributeString("Option" + (y + 1), Campaign.Modules[x].Options.OptionsList[y]);
        //        }
        //        XML.WriteEndElement();
        //        Progress += 1;
        //        Pro.UpdateProgress(Progress);
        //        XML.WriteStartElement("OptionDirections");
        //        for (int y = 0; y < Campaign.Modules[x].Options.OptionDirections.Count; y++)
        //        {
        //            XML.WriteAttributeString("OptionDirection" + (y + 1), Convert.ToString(Campaign.Modules[x].Options.OptionDirections[y]));
        //        }
        //        XML.WriteEndElement();
        //        Progress += 1;
        //        Pro.UpdateProgress(Progress);
        //        XML.WriteEndElement();
        //        XML.WriteEndElement();
        //        Progress += 1;
        //        Pro.UpdateProgress(Progress);
        //    }
        //    XML.WriteEndElement();
        //    XML.WriteEndDocument();
        //    XML.Close();
        //    Pro.Close();
        //    ResetExport();
        //}
    }
}
