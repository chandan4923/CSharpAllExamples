using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };

            var num = from n in nums
                      where n > 0
                      select n;

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
