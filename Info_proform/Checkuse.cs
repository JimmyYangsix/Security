using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management;
using System.Security.Cryptography;

namespace Info_proform
{
    public class Checkuse
    {
        public static string first()//U盘插入检测
        {
            DriveInfo[] s = DriveInfo.GetDrives();
            foreach (DriveInfo i in s)
            {
                if (i.DriveType == DriveType.Removable)
                {
                    Publicinfo.isAccept = true;
                    return i.RootDirectory.ToString();
                }
            }
            return null;
        }
        public static string GetMD5(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(myString);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;
            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x");
            }
            return byte2String;
        }
        public static void Second()
        {
            ReadFile.ReadFiles(Publicinfo.Wpath + "data.dat");
            if (Publicinfo.info_1 == Publicinfo.info_2)
            {
                Publicinfo.isImportant = true;
            }
        }
    }
}
