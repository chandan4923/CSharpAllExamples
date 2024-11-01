using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    class Program
    {
        delegate void CountIt();
        static void Main(string[] args)
        {
            CountIt count = delegate
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            };

            count();
        }
    }
}
