using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        delegate int Incr(int v);

        delegate bool IsEven(int v);

        static void Main(string[] args)
        {
            Incr incr = count => count + 2;

            int i=0;
            while (i <= 10)
            {
                i=incr(i);
                Console.WriteLine("Value of i is: "+i);
            }

            IsEven isEven = n => n % 2 == 0;

            int j = 0;
            while (j <= 10)
            {
                if (isEven(j))
                {
                    Console.WriteLine(j+" is even number");
                }
                else
                {
                    Console.WriteLine(j+" is odd number");
                }
                j = incr(j);
            }

        }
    }
}
