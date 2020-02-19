using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 閏年
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入民國幾年:");
            string year = Console.ReadLine();
            int year1 = int.Parse(year);
            int year2 = year1 + 1911;
            int daysInFeb = System.DateTime.DaysInMonth(year2, 2);

            if (daysInFeb == 29)
            {
                Console.WriteLine($"民國{year1}年是閏年");
            }
            else 
            {
                Console.WriteLine($"民國{year1}年不是閏年");
            }
            Console.ReadLine();
        }
    }
}
