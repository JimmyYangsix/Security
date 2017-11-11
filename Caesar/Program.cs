using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int choice = 0;
            int count = 0;
            int key = 3;
            while (true)
            {
                Console.WriteLine("请输入要进行操作字符串的数量,默认为1");
                try
                {
                    count = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入有误，选取为默认");
                    count = 1;
                }
                input = new string[count];
                Console.WriteLine("选择要进行的操作,默认为加密");
                Console.WriteLine("1.凯撒加密");
                Console.WriteLine("2.凯撒解密");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入有误，选取为默认");
                    choice = 1;
                }
                Console.WriteLine("请输入key值，默认为3");
                try
                {
                    key = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入有误，选取为默认");
                    key = 3;
                }
                if (key > 26)
                {
                    Console.WriteLine("KEY值有误，默认为3");
                }
                Console.WriteLine("请输入对应的字符串，完成一个字符串的输入后，回车即可");
                for (int j = 0; j < count; j++)
                {
                    input[j] = Console.ReadLine();
                }
                if (choice == 1)
                {
                    for (int j = 0; j < count; j++)
                    {
                        encrypation(input[j], key);
                    }
                }
                else
                {
                    for (int j = 0; j < count; j++)
                    {
                        deciphering(input[j], key);
                    }
                }
                Console.WriteLine("操作完成");
                Console.WriteLine("是否继续操作？Y/N");
                if (Console.ReadLine() == "N")
                {
                    break;
                }
            }

        }
        public static void encrypation(String str, int key)
        {//加密方法
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
            string output = sb.ToString();
            Console.WriteLine(output);
        }
        public static void deciphering(String str, int key)
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
            string output = sb.ToString();
            Console.WriteLine(output);
        }
    }
}
