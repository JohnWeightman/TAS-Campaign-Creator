﻿using System;
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

        #region Random Data

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
            Campaign.Modules[Mod].Options.OptionDirectionStrings.Add(Campaign.Modules[Ran.Next(0, Campaign.Modules.Count - 1)].ID);
            Campaign.Modules[Mod].Options.OptionDirectionStrings.Add(Campaign.Modules[Ran.Next(0, Campaign.Modules.Count - 1)].ID);
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

        #endregion

        #region Playablecampaign

        public static void PlayableCampaign()
        {
            while(Storage.Campaign.Modules.Count < 6)
            {
                Campaign.NewModule();
            }
            Module1();
            Module2();
            Module3();
            Module4();
            Module5();
            Module6();
        }

        static void Module1()
        {
            Campaign.Modules[0].Story.Add("Welcome to TAS Infinite!");
            Campaign.Modules[0].ModType = 0;
            Campaign.Modules[0].Options.OptionsList.Add("Continue");
            Campaign.Modules[0].Options.OptionDirectionStrings.Add(Campaign.Modules[1].ID);
        }

        static void Module2()
        {
            Campaign.Modules[1].Story.Add("Your stood in town, what would you like to do?");
            Campaign.Modules[1].ModType = 0;
            Campaign.Modules[1].Options.OptionsList.Add("Go to Shop");
            Campaign.Modules[1].Options.OptionsList.Add("Go to Arena");
            Campaign.Modules[1].Options.OptionsList.Add("Go Home");
            Campaign.Modules[1].Options.OptionDirectionStrings.Add(Campaign.Modules[2].ID);
            Campaign.Modules[1].Options.OptionDirectionStrings.Add(Campaign.Modules[4].ID);
            Campaign.Modules[1].Options.OptionDirectionStrings.Add(Campaign.Modules[3].ID);
        }

        static void Module3()
        {
            Campaign.Modules[2].Story.Add("You head to the shop but its closed.");
            Campaign.Modules[2].ModType = 0;
            Campaign.Modules[2].Options.OptionsList.Add("Return to Town");
            Campaign.Modules[2].Options.OptionDirectionStrings.Add(Campaign.Modules[1].ID);
        }

        static void Module4()
        {
            Campaign.Modules[3].Story.Add("Your standing inside your bedroom.");
            Campaign.Modules[3].ModType = 0;
            Campaign.Modules[3].Options.OptionsList.Add("Go to Town");
            Campaign.Modules[3].Options.OptionsList.Add("Go to Bed");
            Campaign.Modules[3].Options.OptionDirectionStrings.Add(Campaign.Modules[1].ID);
            Campaign.Modules[3].Options.OptionDirectionStrings.Add(Campaign.Modules[5].ID);
        }

        static void Module5()
        {
            Campaign.Modules[4].Story.Add("You step into the arena to face your opponent!");
            Campaign.Modules[4].ModType = 1;
            Campaign.Modules[4].Options.OptionsList.Add("Continue");
            Campaign.Modules[4].Options.OptionDirectionStrings.Add(Campaign.Modules[1].ID);
            Campaign.Modules[4].Encounter.EnemyTypes.Add("Bandit");
            Campaign.Modules[4].Encounter.EnemyNumber.Add(1);
        }

        static void Module6()
        {
            Campaign.Modules[5].Story.Add("You wake up feeling refreshed!");
            Campaign.Modules[5].ModType = 0;
            Campaign.Modules[5].Options.OptionsList.Add("Continue");
            Campaign.Modules[5].Options.OptionDirectionStrings.Add(Campaign.Modules[3].ID);
        }
        #endregion
    }
}
