using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_ROT
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            Console.WriteLine("欢迎使用ROT回旋踢加密解密小玩意  ---Author：KailYang");
            Console.WriteLine("请输入要进行操作字符串");
            string input = Console.ReadLine();
            while (true)
            {
                menu();
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入有误，默认为选择1");
                    choice = 1;
                }
                switch (choice)
                {
                    case 1: encrypation_rot5(input); break;
                    case 2: deciphering_rot5(input); break;
                    case 3: encrypation_rot13(input); break;
                    case 4: deciphering_rot13(input); break;
                    case 5: encrypation_rot18(input); break;
                    case 6: deciphering_rot18(input); break;
                    case 7: encrypation_rot47(input); break;
                    case 8: deciphering_rot47(input); break;
                }
                Console.WriteLine("是否继续？Y/N");
                string userchoice = Console.ReadLine();
                if (userchoice == "N" || userchoice == "n")
                {
                    break;
                }
            }
        }
        private static void menu()
        {
            Console.WriteLine("请选择要进行的操作");
            Console.WriteLine("1.ROT5加密");
            Console.WriteLine("2.ROT5解密");
            Console.WriteLine("3.ROT13加密");
            Console.WriteLine("4.ROT13解密");
            Console.WriteLine("5.ROT18加密");
            Console.WriteLine("6.ROT18解密");
            Console.WriteLine("7.ROT47加密");
            Console.WriteLine("8.ROT47解密");
        }
        private static void encrypation_rot5(String str)
        {//rot5加密方法
            char[] chararry = str.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 48 && chararry[i] <= 57)
                {
                    chararry[i] = (char)(chararry[i] + 5);
                    if (!(chararry[i] >= 48 && chararry[i] <= 57))
                    {
                        chararry[i] = (char)(chararry[i] - 10);
                    }
                }
                //一般加密方法
                else
                {
                    chararry[i] = (char)(chararry[i]);
                }
            }
            outputslove(chararry);
        }
        private static void encrypation_rot13(String str)
        {//rot13加密方法
            char[] chararry = str.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 65 && chararry[i] <= 90)
                {//大写时                  
                    chararry[i] = (char)(chararry[i] + 13);
                    if (!(chararry[i] >= 65 && chararry[i] <= 90))
                    {
                        chararry[i] = (char)(chararry[i] - 26);
                    }
                }
                else if (chararry[i] >= 97 && chararry[i] <= 122)
                {//小写时
                    chararry[i] = (char)(chararry[i] + 13);
                    if (!(chararry[i] >= 97 && chararry[i] <= 122))
                    {
                        chararry[i] = (char)(chararry[i] - 26);
                    }
                }
                //一般加密方法
                else
                {
                    chararry[i] = (char)(chararry[i]);
                }
            }
            outputslove(chararry);
        }
        private static void encrypation_rot18(String str)
        {//rot18加密方法
            char[] chararry = str.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 65 && chararry[i] <= 90)
                {//大写时                  
                    chararry[i] = (char)(chararry[i] + 13);
                    if (!(chararry[i] >= 65 && chararry[i] <= 90))
                    {
                        chararry[i] = (char)(chararry[i] - 26);
                    }
                }
                else if (chararry[i] >= 97 && chararry[i] <= 122)
                {//小写时
                    chararry[i] = (char)(chararry[i] + 13);
                    if (!(chararry[i] >= 97 && chararry[i] <= 122))
                    {
                        chararry[i] = (char)(chararry[i] - 26);
                    }
                }
                else if (chararry[i] >= 48 && chararry[i] <= 57)
                {//数字时
                    chararry[i] = (char)(chararry[i] + 5);
                    if (!(chararry[i] >= 48 && chararry[i] <= 57))
                    {
                        chararry[i] = (char)(chararry[i] - 10);
                    }
                    //一般解密方法
                }
                else
                {
                    chararry[i] = (char)(chararry[i]);
                }
            }
            outputslove(chararry);
        }
        private static void encrypation_rot47(String str)
        {//rot47加密方法
            char[] chararry = str.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 33 && chararry[i] <= 126)
                {
                    chararry[i] = (char)(chararry[i] + 47);
                    if (!(chararry[i] >= 33 && chararry[i] <= 126))
                    {
                        chararry[i] = (char)(chararry[i] - 94);
                    }
                }
                //一般加密方法
                else
                {
                    chararry[i] = (char)(chararry[i]);
                }
            }
            outputslove(chararry);
        }
        private static void deciphering_rot5(String str)
        {//rot5解密方法
            char[] chararry = str.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 48 && chararry[i] <= 57)
                {
                    chararry[i] = (char)(chararry[i] - 5);
                    if (!(chararry[i] >= 48 && chararry[i] <= 57))
                    {
                        chararry[i] = (char)(chararry[i] + 10);
                    }
                }
                //一般加密方法
                else
                {
                    chararry[i] = (char)(chararry[i]);
                }
            }
            outputslove(chararry);
        }
        private static void deciphering_rot13(String str)
        {//rot13解密方法
            char[] chararry = str.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 65 && chararry[i] <= 90)
                {//大写时                  
                    chararry[i] = (char)(chararry[i] - 13);
                    if (!(chararry[i] >= 65 && chararry[i] <= 90))
                    {
                        chararry[i] = (char)(chararry[i] + 26);
                    }
                }
                else if (chararry[i] >= 97 && chararry[i] <= 122)
                {//小写时
                    chararry[i] = (char)(chararry[i] - 13);
                    if (!(chararry[i] >= 97 && chararry[i] <= 122))
                    {
                        chararry[i] = (char)(chararry[i] + 26);
                    }
                }
                //一般加密方法
                else
                {
                    chararry[i] = (char)(chararry[i]);
                }
            }
            outputslove(chararry);
        }
        private static void deciphering_rot18(String str)
        {//rot18解密方法
            char[] chararry = str.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 65 && chararry[i] <= 90)
                {//大写时                  
                    chararry[i] = (char)(chararry[i] - 13);
                    if (!(chararry[i] >= 65 && chararry[i] <= 90))
                    {
                        chararry[i] = (char)(chararry[i] + 26);
                    }
                }
                else if (chararry[i] >= 97 && chararry[i] <= 122)
                {//小写时
                    chararry[i] = (char)(chararry[i] - 13);
                    if (!(chararry[i] >= 97 && chararry[i] <= 122))
                    {
                        chararry[i] = (char)(chararry[i] + 26);
                    }
                }
                else if (chararry[i] >= 48 && chararry[i] <= 57)
                {//数字时
                    chararry[i] = (char)(chararry[i] + 5);
                    if (!(chararry[i] >= 48 && chararry[i] <= 57))
                    {
                        chararry[i] = (char)(chararry[i] - 10);
                    }
                }
                else  //一般解密方法
                {
                    chararry[i] = (char)(chararry[i]);
                }
            }
            outputslove(chararry);
        }
        private static void deciphering_rot47(String str)
        {//rot47解密方法
            char[] chararry = str.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < str.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 33 && chararry[i] <= 126)
                {
                    chararry[i] = (char)(chararry[i] - 47);
                    if (!(chararry[i] >= 33 && chararry[i] <= 126))
                    {
                        chararry[i] = (char)(chararry[i] + 94);
                    }
                }
                //一般加密方法
                else
                {
                    chararry[i] = (char)(chararry[i]);
                }
            }
            outputslove(chararry);
        }
        private static void outputslove(char[] chararry)//构造字符串并输出
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(chararry);
            string output = sb.ToString();
            Console.WriteLine(output);
        }
    }
}
