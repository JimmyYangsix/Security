using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto___Transposition_I
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            Console.WriteLine("请输入字符串");
            string input = Console.ReadLine();
            char[] slove = input.ToCharArray();
            char transposition = slove[0];
            for (int i = 0; i < slove.Length; i++)
            {
                if(i%2==1)
                {
                    transposition = slove[i - 1];
                    slove[i - 1] = slove[i];
                    slove[i] = transposition;
                }
            }
            
            for(int j = 0;j<slove.Length;j++)
            {
                output += slove[j];
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
