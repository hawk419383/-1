using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迴圈導置1
{
    class Program
    {
        static void Main(string[] args)
        {
            string final=" ";
            Console.WriteLine("請輸入一列有逗點分隔的數字 :");
            
            string text = Console.ReadLine();
            
            string[] words = text.Split(',');
            int[] num = Array.ConvertAll(words, int.Parse);
            Array.Reverse(num);

            for (int i = 0; i < num.Length; i++) 
            {

                final += ($"{num[i]},");
               
            }
            final = final.TrimEnd(',');
            Console.WriteLine(final);
            Console.Read();

        }
    }
}
