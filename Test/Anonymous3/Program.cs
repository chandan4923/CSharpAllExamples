using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous3
{

    delegate int CountIt(int i);

    class varData
    {
        public static int sum = 0;

        public static CountIt Counter()
        {
            CountIt count = delegate (int j)
            {
                for (int i = 0; i < j; i++)
                {
                    sum += i;
                }
                return sum;
            };
            return count;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            CountIt c =varData.Counter();

            result = c(5);
            Console.WriteLine("Summation of 5 is: "+result);
            result = c(10);
            Console.WriteLine("Summation of 10 is: "+result);
            
             
        }
    }
}
