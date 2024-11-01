using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2,-3, 3, 0,-8,12,19,6,9, -4, 5 };

            var num = from n in nums
                      where n > 0
                      & n<10
                      select n;

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
