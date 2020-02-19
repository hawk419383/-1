using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迴圈倒置2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("請輸入一個數字 :");
            string input = Console.ReadLine();
            //string input = "5";
            int x = int.Parse(input);

            for (int i = x; i > 0; i--)//倒印
            {
                for (int y = i; y < x + 1; y++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
