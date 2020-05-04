using System;
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

        public static void LoadGameObjects()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load("GameObjects.xml");
            foreach(XmlNode Node in Doc.DocumentElement)
            {
                if(Node.Name == "Enemies")
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
                else if(Node.Name == "Weapons")
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
                        Count += 1;
                    }
                    foreach (Weapon Weapon in WeapTemp)
                        Weapons.Add(Weapon);
                }
                else if(Node.Name == "Armour")
                {
                    int ChildCount = Convert.ToInt32(Node.Attributes[0].Value);
                    int Count = 0;
                    Armour[] ArmTemp = new Armour[ChildCount];
                    foreach(XmlNode Child in Node.ChildNodes)
                    {
                        ArmTemp[Count] = new Armour();
                        ArmTemp[Count].Name = Child.Name;
                        ArmTemp[Count].AC = Convert.ToInt32(Child.Attributes[1].Value);
                        ArmTemp[Count].Weight = Child.Attributes[2].Value;
                        Count += 1;
                    }
                    foreach (Armour Arm in ArmTemp)
                        Armour.Add(Arm);
                }
            }
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
}
