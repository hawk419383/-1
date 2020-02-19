using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 機偶數判斷2
{
    class Program
    {
        static void Main(string[] args)
        {
            string odd = "";
            string even = "";
            Console.WriteLine("請輸入一串逗點分隔的數字");
            string input = Console.ReadLine();

            string[] nums = input.Split(','); //nums： 分割後的字串
            int[] num_int = Array.ConvertAll(nums, int.Parse); //轉Int
            Array.Sort(num_int);//排序
            foreach (int n in num_int)
            {
                if (n % 2 == 1)
                {
                    odd += $"{n},";    //判斷為odd的丟到這個字串            
                }
                else
                {
                    even += $"{n},";
                }
            }
            odd = odd.TrimEnd(',');
            even = even.TrimEnd(',');

            Console.WriteLine($"偶數:{odd}\n 基數:{even}");
            Console.ReadLine();
        }    

    }
}
