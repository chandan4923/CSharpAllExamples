using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous2
{
    class Program
    {
        delegate int Output(int i);
        static void Main(string[] args)
        {

            int Sum = 0;

            Output op = delegate (int j)
            {
                for (int i = 0; i < j; i++)
                {
                    Sum += i;
                }
                return Sum;
            };

            Console.WriteLine(op(20));

        }
    }
}
