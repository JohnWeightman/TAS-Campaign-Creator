using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAS_Campagin_Creator
{
    [Serializable]
    class Campaign
    {
        public string Name = "Campaign1";
        public Settings Settings = new Settings();
        public List<Module> Modules = new List<Module>();

        public void NewModule()
        {
            Module NewMod = new Module();
            NewMod.Name = SetModName();
            NewMod.ID = AssignRandomID();
            Modules.Add(NewMod);
        }

        string SetModName()
        {
            int Count = 0;
            string Name = "";
            bool Unique = false;
            while (!Unique)
            {
                Unique = !Unique;
                Count++;
                Name = "Module" + Count;
                foreach(Module Mod in Modules)
                {
                    if(Name == Mod.Name)
                    {
                        Unique = !Unique;
                        break;
                    }
                }
            }
            return Name;
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
                    IDArr[x] = Char[Storage.Ran.Next(0, Char.Count - 1)];
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

    [Serializable]
    class Module
    {
        public Options Options = new Options();
        public Encounters Encounter = new Encounters();
        public Shops Shop = new Shops();
        public Traps Trap = new Traps();
        public AbilitySaves ABSaves = new AbilitySaves();
        public string Name = "Module1";
        public byte ModType = 0;
        public string ID = "";
        public List<string> Story = new List<string>();

        public void NewTrap(Traps TrapObj)
        {
            Trap.Name = TrapObj.Name;
            Trap.DiceNum = TrapObj.DiceNum;
            Trap.DiceSize = TrapObj.DiceSize;
            Trap.Modifier = TrapObj.Modifier;
            Trap.SaveType = TrapObj.SaveType;
            Trap.SaveTarget = TrapObj.SaveTarget;
            Trap.SaveSuccess = TrapObj.SaveSuccess;
            Trap.SaveFail = TrapObj.SaveFail;
        }
    }

    [Serializable]
    class Options
    {
        public List<string> OptionsList = new List<string>();
        public List<int> OptionDirections = new List<int>();
        public List<string> OptionDirectionStrings = new List<string>();
    }

    [Serializable]
    class Encounters
    {
        public List<string> EnemyTypes = new List<string>();
        public List<int> EnemyNumber = new List<int>();
    }

    [Serializable]
    class Shops
    {
        public List<Weapon> WeaponStock = new List<Weapon>();
        public List<Armour> ArmourStock = new List<Armour>();
        public List<Potions> PotionStock = new List<Potions>();
        public sbyte ItemType;

        public void AddWeapon(Weapon NewWeapon)
        {
            Weapon Weapon = new Weapon();
            Weapon.Name = NewWeapon.Name;
            Weapon.Damage = NewWeapon.Damage;
            Weapon.TwoHanded = NewWeapon.TwoHanded;
            Weapon.Versatile = NewWeapon.Versatile;
            Weapon.Cost = NewWeapon.Cost;
            WeaponStock.Add(Weapon);
        }

        public void AddArmour(Armour NewArmour)
        {
            Armour Armour = new Armour();
            Armour.Name = NewArmour.Name;
            Armour.AC = NewArmour.AC;
            Armour.Weight = NewArmour.Weight;
            Armour.Cost = NewArmour.Cost;
            ArmourStock.Add(Armour);
        }

        public void AddPotion(Potions NewPotion)
        {
            Potions Potion = new Potions();
            Potion.Name = NewPotion.Name;
            Potion.DiceNum = NewPotion.DiceNum;
            Potion.DiceSize = NewPotion.DiceSize;
            Potion.Modifier = NewPotion.Modifier;
            Potion.Cost = NewPotion.Cost;
            PotionStock.Add(Potion);
        }
    }

    [Serializable]
    class AbilitySaves
    {
        public string SaveType = "";
        public int SaveTarget = 0;
        public string SaveSuccess = "";
        public string SaveFail = "";
    }

    #region Campaign Settings
    [Serializable]
    class Settings
    {
        public General General = new General();
        public PlayerSettings Player = new PlayerSettings();
        public EnemySettings Enemeis = new EnemySettings();
    }

    [Serializable]
    class General
    {

    }

    [Serializable]
    class PlayerSettings
    {
        public int FirstLevelUp = 50;
        public int LevelUpIncrease = 25;
        public bool SetPlayerStats = false;
        public int HP = 0;
        public int Str = 0;
        public int Dex = 0;
        public int Con = 0;
        public string Weapon = "";
        public string Armour = "";
    }

    [Serializable]
    class EnemySettings
    {
        public int EnemyNamePlateColourGreen = 100;
        public int EnemyNamePlateColourDarkGreen = 80;
        public int EnemyNamePlateColourDarkYellow = 50;
        public int EnemyNamePlateColourRed = 20;
        public int EnemyNamePlateColourDarkRed = 1;
    }
    #endregion
}
