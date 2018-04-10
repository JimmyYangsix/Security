using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Info_proform
{
    public class ReadFile
    {
        public static int type;//记录类型
        public static bool GetinputFile(string inputFilePath)//对输入文件的判定
        {
            FileInfo infolen1 = new FileInfo(inputFilePath);
            Publicinfo.Cindex = infolen1.Length.ToString();
            string booltype = inputFilePath.Substring(inputFilePath.Length - 4, 4);
            if (booltype.Equals(".txt")) //如果扩展名为“.txt”，先隐写，再伪加密
            {
                type = 1;
                return true;
            }
            else if (booltype.Equals(".zip"))//如果扩展名为“.zip”，先伪加密，再隐写
            {
                type = 2;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool GetuseFile(string usingFilePath)//对介质文件的判定
        {
            FileStream stream = new FileStream(usingFilePath, FileMode.Open);

            if (stream.Length > 80000)
            {
                System.Windows.Forms.MessageBox.Show("图片过大");
                stream.Close();
                return false;
            }
            string booltype = usingFilePath.Substring(usingFilePath.Length - 4, 4);
            if (booltype.Equals(".jpg")) //如果扩展名为“.jpg”，进行隐写
            {
                stream.Close();
                return true;
            }
            else
            {
                stream.Close();
                return false;
            }
        }
        public static string SetoutputFile(string path1, string path2, string path3, bool isFile)//path3为输出目录
        {
            string hexstr1;
            if (isFile)
            {
                hexstr1 = SloveFile(path1, false);//获得文件1十六进制字符串
            }
            else
            {
                hexstr1 = SloveAll(path1);//获得信息的十六进制字符串
            }
            string hexstr2 = SloveFile(path2, false);//获得文件2十六进制字符传
            string outFilepath = AddSloveFile(hexstr1, hexstr2, path3);
            return outFilepath;
        }
        public static string SloveFile(string path1, bool y)//文件转16进制
        {
            string hexstr = "";
            FileInfo infolen1 = new FileInfo(path1);
            FileStream stream = new FileStream(path1, FileMode.Open);
            byte[] buffer = new byte[infolen1.Length];
            stream.Read(buffer, 0, buffer.Length);
            stream.Dispose();
            if (!y)
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    hexstr += buffer[i].ToString("X2");
                }
            }
            else
            {
                for (int i = buffer.Length - Int32.Parse(Publicinfo.Cindex); i < buffer.Length; i++)
                {
                    hexstr += buffer[i].ToString("X2");
                }
            }
            return hexstr;
        }
        public static string SloveAll(string text)//字符串转16进制
        {
            string hexstr = "";
            byte[] buffer = System.Text.Encoding.Default.GetBytes(text);
            for (int i = 0; i < buffer.Length; i++)
            {
                hexstr += buffer[i].ToString("X2");
            }
            return hexstr;
        }
        public static string AddSloveFile(string hex1, string hex2, string outpath)//进行俩文件操作
        {
            hex2 += hex1;
            string hexstr3 = hex2.Replace(" ", "");
            if ((hexstr3.Length % 2) != 0)
                hexstr3 += " ";
            byte[] buffer3 = new byte[hexstr3.Length / 2];
            for (int i = 0; i < buffer3.Length; i++)
                buffer3[i] = Convert.ToByte(hexstr3.Substring(i * 2, 2), 16);
            string outputFilePath = outpath + @"\output.jpg";
            FileStream outputfs = new FileStream(outputFilePath, FileMode.Create);
            outputfs.Write(buffer3, 0, buffer3.Length);
            outputfs.Close();
            return outputFilePath;
        }
        public static string UAddSloveFile(string hex, string unoutpath)
        {
            string uhex = hex.Replace(" ", "");
            if ((uhex.Length % 2) != 0)
                uhex += " ";
            byte[] unbuffer = new byte[Int32.Parse(Publicinfo.Cindex)];
            for (int i = 0; i < unbuffer.Length; i++)
                unbuffer[i] = Convert.ToByte(uhex.Substring(i * 2, 2), 16);
            string outputFilePath = unoutpath + @"\output.doc";
            FileStream outputfs = new FileStream(outputFilePath, FileMode.Create);
            outputfs.Write(unbuffer, 0, unbuffer.Length);
            outputfs.Close();
            return outputFilePath;
        }
        public static string USloveAll(string text)//16进制转字符串
        {
            string uhex = text.Replace(" ", "");
            if ((uhex.Length % 2) != 0)
                uhex += " ";
            byte[] unbuffer = new byte[Int32.Parse(Publicinfo.Cindex)];
            for (int i = 0; i < unbuffer.Length; i++)
                unbuffer[i] = Convert.ToByte(uhex.Substring(i * 2, 2), 16);
            string outtext = System.Text.Encoding.Default.GetString(unbuffer); ;//输出内容
            return outtext;
        }
        public static bool WriteFile(string text)//文件写入
        {
            char[] texts = text.ToCharArray();
            byte[] buffer = new byte[texts.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = Convert.ToByte(texts[i]);
            }
            string outputfilePath = Publicinfo.Wpath + "data.dat";
            FileStream outputfs = new FileStream(outputfilePath, FileMode.Create);
            outputfs.Write(buffer, 0, buffer.Length);
            outputfs.Close();
            return true;
        }
        public static void ReadFiles(string Fpath)//文件读入
        {
            FileInfo infolen1 = new FileInfo(Fpath);
            try
            {
                FileStream stream = new FileStream(Fpath, FileMode.Open);
                byte[] buffer = new byte[infolen1.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Dispose();
                Publicinfo.info_2 = System.Text.Encoding.Default.GetString(buffer);
            }
            catch
            {
                Publicinfo.isImportant = false;

            }

        }
    }
}
