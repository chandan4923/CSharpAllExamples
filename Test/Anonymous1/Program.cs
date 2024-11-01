using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous1
{
    class Program
    {
        delegate void CountIt(int end);
        static void Main(string[] args)
        {
            CountIt count = delegate (int end)
            {
                for (int i = 0; i < end; i++)
                {
                    Console.WriteLine(i);
                }
            };
            count(10);

        }
    }
}
