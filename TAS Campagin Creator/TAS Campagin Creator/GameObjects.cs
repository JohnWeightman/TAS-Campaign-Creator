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
            XmlReader XML = XmlReader.Create("GameObjects.xml");
            while (XML.Read())
            {

            }
        }
    }
}
