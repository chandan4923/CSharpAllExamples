using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, -3, 3, 0, -8, 12, 19, 6, 9, -4, 5 };

            var num = from n in nums
                      orderby n descending
                      select n;

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
