using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCalling
{
    class A
    {
        public A()
        {
            Console.WriteLine("Constructing A");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("Constructing B");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("Constructing C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
        }
    }
}
