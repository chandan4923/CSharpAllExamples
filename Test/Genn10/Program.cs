using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn10
{

    class A
    {

    }
    class B:A
    {

    }

    class Gen<T,V> where V : T
    {
        public Gen()
        {
            Console.WriteLine("Hi Chandan!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gen<A, B> gen = new Gen<A, B>();
            Gen<B, A> gen1 = new Gen<B,A>();

        }
    }
}
