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

        public static void AddTempData()
        {
            for (int x = 0; x < 10; x++)
                Campaign.NewModule();
            for(int x = 0; x < 10; x++)
            {
                AddStory(x);
                AddOptions(x);
                AddOptionTypes(x);
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

        static void AddOptionTypes(int Mod)
        {
            Campaign.Modules[Mod].Options.OptionType.Add(0);
            Campaign.Modules[Mod].Options.OptionType.Add(1);
        }
    }
}
