using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwrOfTwoIndexer
{

    class PowerOfTwo
    {
        public int this[int index]
        {
            get
            {
                if (index >= 0 & index <= 15) return Power(index);
                else return -1;
            }
        }

        private int Power(int index)
        {
            int result=1;
            for (int i = 0; i <= index; i++)
                result = result *2;

            return result;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            PowerOfTwo P = new PowerOfTwo();


            Console.WriteLine("Powers of two are: ");
            for(int i=0; i <= 15; i++)
            {
                Console.Write(P[i]+" ");
            }

            Console.WriteLine();
            Console.WriteLine(P[-2]+" "+P[-7]);

            P[1] = 90;
        }
    }
}
