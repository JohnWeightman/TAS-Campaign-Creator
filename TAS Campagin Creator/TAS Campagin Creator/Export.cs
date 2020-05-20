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
        static int TrapJobs = 0;
        static int Progress = 0;

        public static void ExportCampaign()
        {
            CalculateJobs();
            Pro.Show();
            Pro.InitiliaseProgressBar(TotalJobs);
            Storage.Campaign.InitiliaseDataForExport();
            XmlWriter XML = XmlWriter.Create("Campaigns\\" + Storage.Campaign.Name + ".xml");
            XML.WriteStartDocument();
            WriteXMLFile(XML);
            XML.WriteEndDocument();
            XML.Close();
            Pro.Hide();
            ResetExport();
        }

        static void WriteXMLFile(XmlWriter XML)
        {
            XML.WriteStartElement(Storage.Campaign.Name);
            WriteSettingsData(XML);
            WriteCampaignData(XML);
            XML.WriteEndElement();
        }

        static void WriteSettingsData(XmlWriter XML)
        {
            XML.WriteStartElement("Settings");
            XML.WriteEndElement();
        }

        static void WriteCampaignData(XmlWriter XML)
        {
            XML.WriteStartElement("Campaign");
            for(int ModNum = 0; ModNum < Storage.Campaign.Modules.Count; ModNum++)
            {
                WriteModuleData(XML, Storage.Campaign.Modules[ModNum]);
            }
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("Module");
            XML.WriteAttributeString("Name", Mod.Name);
            XML.WriteAttributeString("ModType", Convert.ToString(Mod.ModType));
            XML.WriteAttributeString("ID", Mod.ID);
            WriteModuleStoryData(XML, Mod);
            WriteModuleOptionData(XML, Mod);
            switch (Mod.ModType)
            {
                case 1:
                    WriteModuleEncounterData(XML, Mod);
                    break;
                case 2:
                    WriteModuleShopData(XML, Mod);
                    break;
                case 3:
                    WriteModuleTrapData(XML, Mod);
                    break;
                default:
                    break;
            }
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleStoryData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("Story");
            for(int x = 0; x < Mod.Story.Count; x++)
                XML.WriteAttributeString("Part" + (x + 1), Mod.Story[x]);
            XML.WriteEndElement();
        }

        static void WriteModuleOptionData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("Options");
            WriteModuleOptionListData(XML, Mod);
            WriteModuleOptionDirectionData(XML, Mod);
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleOptionListData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("OptionsList");
            for (int x = 0; x < Mod.Options.OptionsList.Count; x++)
                XML.WriteAttributeString("Option" + (x + 1), Mod.Options.OptionsList[x]);
            XML.WriteEndElement();
        }

        static void WriteModuleOptionDirectionData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("OptionDirections");
            for (int x = 0; x < Mod.Options.OptionDirections.Count; x++)
                XML.WriteAttributeString("OptionDirection" + (x + 1), Convert.ToString(Mod.Options.OptionDirections[x]));
            XML.WriteEndElement();
        }

        static void WriteModuleEncounterData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("Encounter");
            WriteModuleEncounterEnemyTypeData(XML, Mod);
            WriteModuleEncounterEnemyNumberData(XML, Mod);
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleEncounterEnemyTypeData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("EncounterEnemyType");
            for (int x = 0; x < Mod.Encounter.EnemyTypes.Count; x++)
                XML.WriteAttributeString("EnemyType" + (x + 1), Mod.Encounter.EnemyTypes[x]);
            XML.WriteEndElement();
        }

        static void WriteModuleEncounterEnemyNumberData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("EncounterEnemyNumber");
            for (int x = 0; x < Mod.Encounter.EnemyNumber.Count; x++)
                XML.WriteAttributeString("EnemyNumber" + (x + 1), Convert.ToString(Mod.Encounter.EnemyNumber[x]));
            XML.WriteEndElement();
        }

        static void WriteModuleShopData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("Shop");
            if (Mod.Shop.WeaponStock.Count > 0)
                WriteModuleShopWeaponStockData(XML, Mod);
            if (Mod.Shop.ArmourStock.Count > 0)
                WriteModuleShopArmourStockData(XML, Mod);
            XML.WriteEndElement();
            Progress += 1;
            Pro.UpdateProgress(Progress);
        }

        static void WriteModuleShopWeaponStockData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("WeaponStock");
            for(int x = 0; x < Mod.Shop.WeaponStock.Count; x++)
            {
                XML.WriteStartElement(Mod.Shop.WeaponStock[x].Name);
                XML.WriteAttributeString("Cost", Convert.ToString(Mod.Shop.WeaponStock[x].Cost));
                XML.WriteEndElement();
            }
            XML.WriteEndElement();
        }

        static void WriteModuleShopArmourStockData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("ArmourStock");
            for(int x = 0; x < Mod.Shop.ArmourStock.Count; x++)
            {
                XML.WriteStartElement(Mod.Shop.ArmourStock[x].Name);
                XML.WriteAttributeString("Cost", Convert.ToString(Mod.Shop.ArmourStock[x].Cost));
                XML.WriteEndElement();
            }
            XML.WriteEndElement();
        }

        static void WriteModuleTrapData(XmlWriter XML, Module Mod)
        {
            XML.WriteStartElement("Trap");
            XML.WriteAttributeString("Name", Mod.Trap.Name);
            XML.WriteAttributeString("DiceNumber", Convert.ToString(Mod.Trap.DiceNum));
            XML.WriteAttributeString("DiceSize", Convert.ToString(Mod.Trap.DiceSize));
            XML.WriteAttributeString("Modifier", Convert.ToString(Mod.Trap.Modifier));
            XML.WriteAttributeString("SaveType", Mod.Trap.SaveType);
            XML.WriteAttributeString("SaveTarget", Convert.ToString(Mod.Trap.SaveTarget));
            XML.WriteAttributeString("SaveSuccess", Mod.Trap.SaveSuccess);
            XML.WriteAttributeString("SaveFail", Mod.Trap.SaveFail);
            XML.WriteAttributeString("XPValue", Convert.ToString(Mod.Trap.XPValue));
            XML.WriteEndElement();
        }

        static void CalculateJobs()
        {
            ModuleJobs = Storage.Campaign.Modules.Count;
            OptionJobs = Storage.Campaign.Modules.Count;
            foreach(Module Mod in Storage.Campaign.Modules)
            {
                switch (Mod.ModType)
                {
                    case 1:
                        EncounterJobs++;
                        break;
                    case 2:
                        ShopJobs++;
                        break;
                    case 3:
                        TrapJobs++;
                        break;
                    default:
                        break;
                }            
            }
            TotalJobs = CampaignJobs + ModuleJobs + OptionJobs + EncounterJobs + ShopJobs + TrapJobs;
        }

        static void ResetExport()
        {
            TotalJobs = 0;
            CampaignJobs = 1;
            ModuleJobs = 0;
            OptionJobs = 0;
            EncounterJobs = 0;
            ShopJobs = 0;
            TrapJobs = 0;
            Progress = 0;
            foreach (Module Mod in Storage.Campaign.Modules)
                Mod.Options.OptionDirections.Clear();
        }
    }
}
