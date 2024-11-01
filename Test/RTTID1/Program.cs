using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTTID1
{
    class A
    {
    }
    class B:A 
    { }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            //if(a is B)
            //{
            //    b = (B)a;
            //}
            //else
            //{
            //    b = null;
            //}
            //if (b == null)
            //{
            //    Console.WriteLine("The cast in b=(B)a is not allowed");
            //}
            b = a as B;
            if (b == null)
            {
                Console.WriteLine("The cast in b=(B)a is not allowed");
            }
        }
    }
}
