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
        public static Enemies NPC = new Enemies();
        public static Weapons Weapon = new Weapons();
        public static Armour Armour = new Armour();

        public static void LoadEnemyNPCs()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load("GameObjects.xml");
            foreach(XmlNode Node in Doc.DocumentElement)
            {
                if(Node.Name == "Enemies")
                {
                    foreach(XmlNode Child in Node.ChildNodes)
                    {
                        NPC.EnemyNPCs.Add(Child.Name);
                        NPC.DifBonus.Add(Convert.ToInt32(Child.Attributes[10].Value));
                    }
                }
                else if(Node.Name == "Weapons")
                {
                    foreach(XmlNode Child in Node.ChildNodes)
                    {
                        Weapon.WeaponsList.Add(Child.Name);
                        Weapon.Damage.Add(Convert.ToInt32(Child.Attributes[1].Value));
                        Weapon.TwoHanded.Add(Convert.ToBoolean(Child.Attributes[2].Value));
                        Weapon.Versatile.Add(Convert.ToBoolean(Child.Attributes[3].Value));
                    }
                }
                else if(Node.Name == "Armour")
                {
                    foreach(XmlNode Child in Node.ChildNodes)
                    {
                        Armour.ArmourList.Add(Child.Name);
                        Armour.AC.Add(Convert.ToInt32(Child.Attributes[1].Value));
                        Armour.Weight.Add(Child.Attributes[2].Value);
                    }
                }
            }
        }
    }

    class Enemies
    {
        public List<string> EnemyNPCs = new List<string>();
        public List<int> DifBonus = new List<int>();
    }

    class Weapons
    {
        public List<string> WeaponsList = new List<string>();
        public List<int> Damage = new List<int>();
        public List<bool> TwoHanded = new List<bool>();
        public List<bool> Versatile = new List<bool>();
    }

    class Armour
    {
        public List<string> ArmourList = new List<string>();
        public List<int> AC = new List<int>();
        public List<string> Weight = new List<string>();
    }
}
