using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda1
{
    class Program
    {
        public delegate bool Value(int high, int low, int val);
        static void Main(string[] args)
        {

           Value value =  (high, low, val) => val >= low && val <= high;

            if (value(3, 1, 0))
            {
                Console.WriteLine("1 is the value");
            }

        }
    }
}
