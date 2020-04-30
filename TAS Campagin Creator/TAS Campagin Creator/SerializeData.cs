using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        public static void LoadFromBinary(string FileName)
        {
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

            }
            ObjStream.Close();
        }
    }
}
