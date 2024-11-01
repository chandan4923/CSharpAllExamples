using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTTID
{
    class A { }
    class B : A { }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            if(a is A)
            {
                Console.WriteLine("a is A");
            }
            if(a is B)
            {
                Console.WriteLine("a is B");
            }
            if(b is A)
            {
                Console.WriteLine("b is A");
            }
            if(b is B)
            {
                Console.WriteLine("b is B");
            }
            if(b is object)
            {
                Console.WriteLine("b is object");
            }

        }
    }
}
