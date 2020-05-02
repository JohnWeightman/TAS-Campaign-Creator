using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TAS_Campagin_Creator
{
    static class SerializeData
    {
        static Stream ObjStream = null;
        static BinaryFormatter BForm = null;

        public static void SaveToBinary(string FileName)
        {
            BForm = new BinaryFormatter();
            ObjStream = File.Open(FileName, FileMode.Create);
            BForm.Serialize(ObjStream, Storage.Campaign);
            ObjStream.Close();
        }

        public static void LoadFromBinary(string FileName)  //Still throws errors! Needs coming back to!
        {
            BForm = new BinaryFormatter();
            ObjStream = File.Open(FileName, FileMode.Open);
            try
            {
                while (ObjStream.CanSeek)
                {
                    Storage.Campaign = (Campaign)BForm.Deserialize(ObjStream);
                }
            }
            catch
            {
                //MessageBox.Show("Deserialization Error!");
            }
            ObjStream.Close();
        }
    }
}
