using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USafe1
{
    class Program
    {
       unsafe static void Main(string[] args)
        {
            int count = 99;

            int* p;
            p = &count;

            Console.WriteLine("The initial value of p:" + *p);

            *p = 10;

            Console.WriteLine("The final value of p:" + *p);
        }
    }
}
