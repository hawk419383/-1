using System;

namespace 非迴圈六日
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入西元年:");
            string year = Console.ReadLine();
            int years = int.Parse(year);
            var days= new TimeSpan(years, 1, 1 - years + 1, 1, 1).TotalDays;
        }
    }
}
