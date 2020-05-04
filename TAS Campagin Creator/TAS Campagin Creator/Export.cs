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
        static int EncounterJobs = 0;
        static int ShopJobs = 0;
        static int Progress = 0;

        public static void ExportCampaign()
        {
            CalculateJobs();
            Pro.Show();
            Pro.InitiliaseProgressBar(TotalJobs);
            Storage.Campaign.InitiliaseDataForExport();
            XmlWriter XML = XmlWriter.Create("Campaigns\\" + Storage.Campaign.Name + ".xml");
            XML.WriteStartDocument();
            WriteCampaignData(XML);
            XML.WriteEndDocument();
            XML.Close();
            Pro.Hide();
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
            XML.WriteAttributeString("ID", Storage.Campaign.Modules[ModNum].ID);
            WriteModuleStoryData(XML, ModNum);
            WriteModuleOptionData(XML, ModNum);
            if (Storage.Campaign.Modules[ModNum].ModType == 1)
                WriteModuleEncounterData(XML, ModNum);
            else if (Storage.Campaign.Modules[ModNum].ModType == 2)
                WriteModuleShopData(XML, ModNum);
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
                XML.WriteAttributeString("Option" + (x + 1), Storage.Campaign.Modules[ModNum].Options.OptionsList[x]);
            XML.WriteEndElement();
        }

        static void WriteModuleOptionDirectionData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("OptionDirections");
            for (int x = 0; x < Storage.Campaign.Modules[ModNum].Options.OptionDirections.Count; x++)
                XML.WriteAttributeString("OptionDirection" + (x + 1), Convert.ToString(Storage.Campaign.Modules[ModNum].Options.OptionDirections[x]));
            XML.WriteEndElement();
        }

        static void WriteModuleEncounterData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("Encounter");
            WriteModuleEncounterEnemyTypeData(XML, ModNum);
            WriteModuleEncounterEnemyNumberData(XML, ModNum);
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleEncounterEnemyTypeData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("EncounterEnemyType");
            for (int x = 0; x < Storage.Campaign.Modules[ModNum].Encounter.EnemyTypes.Count; x++)
                XML.WriteAttributeString("EnemyType" + (x + 1), Storage.Campaign.Modules[ModNum].Encounter.EnemyTypes[x]);
            XML.WriteEndElement();
        }

        static void WriteModuleEncounterEnemyNumberData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("EncounterEnemyNumber");
            for (int x = 0; x < Storage.Campaign.Modules[ModNum].Encounter.EnemyNumber.Count; x++)
                XML.WriteAttributeString("EnemyNumber" + (x + 1), Convert.ToString(Storage.Campaign.Modules[ModNum].Encounter.EnemyNumber[x]));
            XML.WriteEndElement();
        }

        static void WriteModuleShopData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("Shop");
            if (Storage.Campaign.Modules[ModNum].Shop.WeaponStock.Count > 0)
                WriteModuleShopWeaponStockData(XML, ModNum);
            if (Storage.Campaign.Modules[ModNum].Shop.ArmourStock.Count > 0)
                WriteModuleShopArmourStockData(XML, ModNum);
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleShopWeaponStockData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("WeaponStock");
            for(int x = 0; x < Storage.Campaign.Modules[ModNum].Shop.WeaponStock.Count; x++)
            {
                XML.WriteStartElement(Storage.Campaign.Modules[ModNum].Shop.WeaponStock[x].Name);
                XML.WriteAttributeString("Cost", Convert.ToString(Storage.Campaign.Modules[ModNum].Shop.WeaponStock[x].Cost));
                XML.WriteEndElement();
            }
            XML.WriteEndElement();
        }

        static void WriteModuleShopArmourStockData(XmlWriter XML, int ModNum)
        {
            XML.WriteStartElement("ArmourStock");
            for(int x = 0; x < Storage.Campaign.Modules[ModNum].Shop.ArmourStock.Count; x++)
            {
                XML.WriteStartElement(Storage.Campaign.Modules[ModNum].Shop.ArmourStock[x].Name);
                XML.WriteAttributeString("Cost", Convert.ToString(Storage.Campaign.Modules[ModNum].Shop.ArmourStock[x].Cost));
                XML.WriteEndElement();
            }
            XML.WriteEndElement();
        }

        static void CalculateJobs()
        {
            ModuleJobs = Storage.Campaign.Modules.Count;
            OptionJobs = Storage.Campaign.Modules.Count;
            foreach(Module Mod in Storage.Campaign.Modules)
            {
                if (Mod.ModType == 1)
                    EncounterJobs += 1;
                else if (Mod.ModType == 2)
                    ShopJobs += 1;
            }
            TotalJobs = CampaignJobs + ModuleJobs + OptionJobs + EncounterJobs + ShopJobs;
        }

        static void ResetExport()
        {
            TotalJobs = 0;
            CampaignJobs = 1;
            ModuleJobs = 0;
            OptionJobs = 0;
            EncounterJobs = 0;
            ShopJobs = 0;
            Progress = 0;
            foreach (Module Mod in Storage.Campaign.Modules)
                Mod.Options.OptionDirections.Clear();
        }
    }
}
