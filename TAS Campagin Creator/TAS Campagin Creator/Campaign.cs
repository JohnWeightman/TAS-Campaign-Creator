﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAS_Campagin_Creator
{
    class Campaign
    {
        public string Name = "Campaign 1";
        public List<Module> Modules = new List<Module>();
        int ModCount = 0;

        public void NewModule()
        {
            Module NewMod = new Module();
            ModCount += 1;
            NewMod.Name = "Module " + ModCount;
            Modules.Add(NewMod);
        }
    }

    class Module
    {
        public Options Options = new Options();
        public string Name = "Module 1";
        public List<string> Story = new List<string>();
    }

    class Options
    {
        public List<string> OptionsList = new List<string>();
    }
}