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
        public static List<string> EnemyNPCs = new List<string>();
        public static List<int> DifBonus = new List<int>();

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
                        EnemyNPCs.Add(Child.Name);
                        DifBonus.Add(Convert.ToInt32(Child.Attributes[10].Value));
                    }
                }
            }
        }
    }
}
