using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usereff
{
    class RefTest
    {
        public void Sqr(ref int i)
        {
            i = i * i;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var refTest = new RefTest();
            int a = 9;
            Console.WriteLine("Value of a is: "+a);

            refTest.Sqr(ref a);
            Console.WriteLine("Value of a after squaring is: " + a);
        }
    }
}
