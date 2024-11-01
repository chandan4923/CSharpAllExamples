using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, -3, 3, 0, -8, 12, 19, 6, 9, -4, 5 };
            var num =nums.Where(n => n > 0).Select(g => g * 10);

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
