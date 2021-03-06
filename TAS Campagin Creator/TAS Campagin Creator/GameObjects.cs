﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TAS_Campagin_Creator
{
    static class GameObjects
    {
        public static List<NPC> Enemies = new List<NPC>();
        public static List<Weapon> Weapons = new List<Weapon>();
        public static List<Armour> Armour = new List<Armour>();
        public static List<Potions> Potions = new List<Potions>();
        public static List<Traps> Traps = new List<Traps>();

        public static void LoadGameObjects()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load("GameObjects.xml");
            foreach(XmlNode Node in Doc.DocumentElement)
            {
                switch (Node.Name)
                {
                    case "Enemies":
                        LoadNPCS(Node);
                        break;
                    case "Weapons":
                        LoadWeapons(Node);
                        break;
                    case "Armour":
                        LoadArmour(Node);
                        break;
                    case "Potions":
                        LoadPotions(Node);
                        break;
                    case "Traps":
                        LoadTraps(Node);
                        break;
                    default:
                        break;
                }
            }
        }

        static void LoadNPCS(XmlNode Node)
        {
            int ChildCount = Convert.ToInt32(Node.Attributes[0].Value);
            int Count = 0;
            NPC[] NPCTemp = new NPC[ChildCount];
            foreach (XmlNode Child in Node.ChildNodes)
            {
                NPCTemp[Count] = new NPC();
                NPCTemp[Count].Name = Child.Name;
                NPCTemp[Count].DifBonus = Convert.ToInt32(Child.Attributes[10].Value);
                Count += 1;
            }
            foreach (NPC NPC in NPCTemp)
                Enemies.Add(NPC);
        }

        static void LoadWeapons(XmlNode Node)
        {
            int ChildCount = Convert.ToInt32(Node.Attributes[0].Value);
            int Count = 0;
            Weapon[] WeapTemp = new Weapon[ChildCount];
            foreach (XmlNode Child in Node.ChildNodes)
            {
                WeapTemp[Count] = new Weapon();
                WeapTemp[Count].Name = Child.Name;
                WeapTemp[Count].Damage = Convert.ToInt32(Child.Attributes[1].Value);
                WeapTemp[Count].TwoHanded = Convert.ToBoolean(Child.Attributes[2].Value);
                WeapTemp[Count].Versatile = Convert.ToBoolean(Child.Attributes[3].Value);
                WeapTemp[Count].Cost = Convert.ToInt32(Child.Attributes[4].Value);
                Count += 1;
            }
            foreach (Weapon Weapon in WeapTemp)
                Weapons.Add(Weapon);
        }

        static void LoadArmour(XmlNode Node)
        {
            int ChildCount = Convert.ToInt32(Node.Attributes[0].Value);
            int Count = 0;
            Armour[] ArmTemp = new Armour[ChildCount];
            foreach (XmlNode Child in Node.ChildNodes)
            {
                ArmTemp[Count] = new Armour();
                ArmTemp[Count].Name = Child.Name;
                ArmTemp[Count].AC = Convert.ToInt32(Child.Attributes[1].Value);
                ArmTemp[Count].Weight = Child.Attributes[2].Value;
                ArmTemp[Count].Cost = Convert.ToInt32(Child.Attributes[3].Value);
                Count += 1;
            }
            foreach (Armour Arm in ArmTemp)
                Armour.Add(Arm);
        }

        static void LoadPotions(XmlNode Node)
        {
            int ChildCount = Convert.ToInt32(Node.Attributes[0].Value);
            int Count = 0;
            Potions[] PotTemp = new Potions[ChildCount];
            foreach (XmlNode Child in Node.ChildNodes)
            {
                PotTemp[Count] = new Potions();
                PotTemp[Count].Name = Child.Attributes[0].Value;
                PotTemp[Count].DiceNum = Convert.ToInt32(Child.Attributes[1].Value);
                PotTemp[Count].DiceSize = Convert.ToInt32(Child.Attributes[2].Value);
                PotTemp[Count].Modifier = Convert.ToInt32(Child.Attributes[3].Value);
                PotTemp[Count].Cost = Convert.ToInt32(Child.Attributes[4].Value);
                Count += 1;
            }
            foreach (Potions Potion in PotTemp)
                Potions.Add(Potion);
        }

        static void LoadTraps(XmlNode Node)
        {
            int ChildCount = Convert.ToInt32(Node.Attributes[0].Value);
            int Count = 0;
            Traps[] TrapTemp = new Traps[ChildCount];
            foreach (XmlNode Child in Node.ChildNodes)
            {
                TrapTemp[Count] = new Traps();
                TrapTemp[Count].Name = Child.Attributes[0].Value;
                TrapTemp[Count].DiceNum = Convert.ToInt32(Child.Attributes[1].Value);
                TrapTemp[Count].DiceSize = Convert.ToInt32(Child.Attributes[2].Value);
                TrapTemp[Count].Modifier = Convert.ToInt32(Child.Attributes[3].Value);
                TrapTemp[Count].SaveType = Child.Attributes[4].Value;
                TrapTemp[Count].SaveTarget = Convert.ToInt32(Child.Attributes[5].Value);
                TrapTemp[Count].SaveSuccess = Child.Attributes[6].Value;
                TrapTemp[Count].SaveFail = Child.Attributes[7].Value;
                TrapTemp[Count].XPValue = Convert.ToInt32(Child.Attributes[8].Value);
                Count += 1;
            }
            foreach (Traps Trap in TrapTemp)
                Traps.Add(Trap);
        }
    }

    class NPC
    {
        public string Name = "";
        public int DifBonus = 0;
    }

    class Weapon
    {
        public string Name = "";
        public int Damage = 0;
        public bool TwoHanded = false;
        public bool Versatile = false;
        public int Cost = 0;
    }

    class Armour
    {
        public string Name = "";
        public int AC = 0;
        public string Weight = "";
        public int Cost = 0;
    }

    class Potions
    {
        public string Name = "";
        public int DiceNum = 0;
        public int DiceSize = 0;
        public int Modifier = 0;
        public int Cost = 0;
    }

    [Serializable]
    class Traps
    {
        public string Name = "";
        public int DiceNum = 0;
        public int DiceSize = 0;
        public int Modifier = 0;
        public string SaveType = "";
        public int SaveTarget = 0;
        public string SaveSuccess = "";
        public string SaveFail = "";
        public int AvgDamage = 0;
        public int MinDamage = 0;
        public int MaxDamage = 0;
        public int XPValue = 0;
    }
}
