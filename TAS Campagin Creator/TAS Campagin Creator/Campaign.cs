using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAS_Campagin_Creator
{
    //[Serializable]
    class Campaign
    {
        public string Name = "Campaign1";
        public List<Module> Modules = new List<Module>();
        int ModCount = 0;
        Random Ran = new Random();

        public void NewModule()
        {
            Module NewMod = new Module();
            ModCount += 1;
            NewMod.Name = "Module" + ModCount;
            NewMod.ID = AssignRandomID();
            Modules.Add(NewMod);
        }

        string AssignRandomID()
        {
            List<char> Char = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g',
                'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'v',
                'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z' };
            char[] IDArr = new char[16];
            bool Unique = false;
            string ID = "";
            while (!Unique)
            {
                Unique = true;
                for (int x = 0; x < IDArr.Length; x++)
                {
                    IDArr[x] = Char[Ran.Next(0, Char.Count - 1)];
                }
                string Temp = new string(IDArr);
                ID = Temp;
                foreach (Module Mod in Modules)
                    if (Mod.ID == ID)
                        Unique = false;
            }
            return ID;
        }

        public void InitiliaseDataForExport()
        {
            SetOptionDirections();
        }

        void SetOptionDirections()
        {
            foreach(Module Mod in Modules)
            {
                for(int x = 0; x < Mod.Options.OptionDirectionStrings.Count; x++)
                {
                    for(int y = 0; y < Modules.Count; y++)
                    {
                        if(Modules[y].ID == Mod.Options.OptionDirectionStrings[x])
                        {
                            Mod.Options.OptionDirections.Add(y);
                        }
                    }
                }
            }
        }
    }

    //[Serializable]
    class Module
    {
        public Options Options = new Options();
        public Encounters Encounter = new Encounters();
        public string Name = "Module1";
        public byte ModType = 0;
        public string ID = "";
        public List<string> Story = new List<string>();
    }

    //[Serializable]
    class Options
    {
        public List<string> OptionsList = new List<string>();
        public List<int> OptionDirections = new List<int>();
        public List<string> OptionDirectionStrings = new List<string>();
    }

    //[Serializable]
    class Encounters
    {
        public List<string> EnemyTypes = new List<string>();
        public List<int> EnemyNumber = new List<int>();
    }
}
