using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_platform
{
    public class Caesar
    {
        public static int key;
        public static Data encrypation(Data a)
        {//加密方法
            string str = a.Datatext;
            Random numkey = new Random();
            key = numkey.Next(1, 23);
            char[] chararry = str.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 65 && chararry[i] <= 90)
                {//大写时                  
                    chararry[i] = (char)(chararry[i] + key);
                    if (!(chararry[i] >= 65 && chararry[i] <= 90))
                    {
                        chararry[i] = (char)(chararry[i] - 26);
                    }
                }
                else if (chararry[i] >= 97 && chararry[i] <= 122)
                {//小写时
                    chararry[i] = (char)(chararry[i] + key);
                    if (!(chararry[i] >= 97 && chararry[i] <= 122))
                    {
                        chararry[i] = (char)(chararry[i] - 26);
                    }
                }
                //一般加密方法
                else
                {
                    chararry[i] = (char)(chararry[i] + key);
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(chararry);
            a.Datatext = sb.ToString();
            a.key = key;
            return a;
        }
        public static string deciphering(String str, int key)
        {//解密方法
            char[] chararry = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表前3位时，加密后是字母表后三位
                if (chararry[i] >= 65 && chararry[i] <= 90)
                {//大写时                  
                    chararry[i] = (char)(chararry[i] - key);
                    if (!(chararry[i] >= 65 && chararry[i] <= 90))
                    {
                        chararry[i] = (char)(chararry[i] + 26);
                    }
                }
                else if (chararry[i] >= 97 && chararry[i] <= 122)
                {//小写时
                    chararry[i] = (char)(chararry[i] - key);
                    if (!(chararry[i] >= 97 && chararry[i] <= 122))
                    {
                        chararry[i] = (char)(chararry[i] + 26);
                    }
                }
                //一般解密密方法
                else
                {
                    chararry[i] = (char)(chararry[i] - key);
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(chararry);
            return sb.ToString();

        }
    }
}
