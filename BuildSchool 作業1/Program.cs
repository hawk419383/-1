using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSchool_作業1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入數字:");
            string input = Console.ReadLine();
            int Value = int.Parse(input);
            if (Value % 2 == 0)
            {
                Console.WriteLine("是偶數");
            }
            else
            {
                Console.WriteLine("是基數");
            }




            Console.Read();
        }
    }
}
