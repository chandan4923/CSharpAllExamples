using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda2
{
    class Program
    {
        delegate int Fact(int i);
        static void Main(string[] args)
        {

            Fact fact = n =>
            {
                int j = 1;
                for (int i = 1; i <= n; i++)
                {
                    j = j * i;
                }
                return j;
            };


            Console.WriteLine("Factorial of 3 is: "+fact(3));
            Console.WriteLine("Factorial of 5 is: "+fact(5));
        }
    }
}
