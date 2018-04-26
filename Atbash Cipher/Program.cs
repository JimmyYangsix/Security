using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atbash_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int choice = 0;
            int count = 0;
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
                Console.WriteLine("1.埃特巴加密");
                Console.WriteLine("2.埃特巴解密");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入有误，选取为默认");
                    choice = 1;
                }
                Console.WriteLine("请输入对应的字符串，完成一个字符串的输入后，回车即可");
                for (int j = 0; j < count; j++)
                {
                    input[j] = Console.ReadLine();
                    encrypation(input[j]);
                }

                Console.WriteLine("操作完成");
                Console.WriteLine("是否继续操作？Y/N");
                if (Console.ReadLine() == "N" || Console.ReadLine() == "n")
                {
                    break;
                }
            }
        }
        public static void encrypation(String input)
        {//加密处理[解密处理]
            char[] chararry = input.ToCharArray();//把字符串转化为字符数组
            for (int i = 0; i < input.Length; i++)
            {
                //当读到字母表后3位时，加密后是字母表前三位
                if (chararry[i] >= 65 && chararry[i] <= 90)
                {//大写时                  
                    chararry[i] = (char)(155-chararry[i]);
                }
                else if (chararry[i] >= 97 && chararry[i] <= 122)
                {//小写时
                    chararry[i] = (char)(219-chararry[i] );
                }
                //一般加密方法
                else
                {
                    chararry[i] = (char)(chararry[i]);
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(chararry);
            string output = sb.ToString();
            Console.WriteLine(output);
        }
    }
}
