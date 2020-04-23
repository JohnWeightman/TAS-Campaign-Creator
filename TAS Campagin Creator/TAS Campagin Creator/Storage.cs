using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAS_Campagin_Creator
{
    static class Storage
    {
        public static Campaign Campaign = new Campaign();
        public static int ModNum = 0;

        static Random Ran = new Random();
        static int ModCount = 100;

        public static void AddTempData()
        {
            for (int x = 0; x < ModCount; x++)
                Campaign.NewModule();
            for(int x = 0; x < ModCount; x++)
            {
                AddStory(x);
                AddOptions(x);
                AddOptionDirections(x);
                AddModuleType(x);
                if (Campaign.Modules[x].ModType == 1)
                    AddModuleEncounter(x);
            }
        }

        static void AddStory(int Mod)
        {
            Campaign.Modules[Mod].Story.Add("aaA");
            Campaign.Modules[Mod].Story.Add("bbB");
            Campaign.Modules[Mod].Story.Add("ccC");
            Campaign.Modules[Mod].Story.Add("ddD");
            Campaign.Modules[Mod].Story.Add("eeE");
        }

        static void AddOptions(int Mod)
        {
            Campaign.Modules[Mod].Options.OptionsList.Add("Continue");
            Campaign.Modules[Mod].Options.OptionsList.Add("Fight");
        }

        static void AddOptionDirections(int Mod)
        {
            Campaign.Modules[Mod].Options.OptionDirectionStrings.Add("Module" + Ran.Next(1, ModCount));
            Campaign.Modules[Mod].Options.OptionDirectionStrings.Add("Module" + Ran.Next(1, ModCount));
        }

        static void AddModuleType(int Mod)
        {
            Campaign.Modules[Mod].ModType = Convert.ToByte(Ran.Next(0, 2));
        }

        static void AddModuleEncounter(int Mod)
        {
            Campaign.Modules[Mod].Encounter.EnemyTypes.Add("Bandit");
            Campaign.Modules[Mod].Encounter.EnemyNumber.Add(Ran.Next(1, 6));
        }
    }
}
