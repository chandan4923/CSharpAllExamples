using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn19
{

    class Gen<T>
    {
        T obj;
        public Gen(T o)
        {
            obj = o;
        }

        public T GetT()
        {
            return obj;
        }
    }

    class Gen1<T> : Gen<T>
    {
        public Gen1(T o): base(o)
        {

        }
        //Console.WriteLine( this.GetT() );
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gen1<string> g1 = new Gen1<string>("Hello");

            Console.WriteLine(g1.GetT());

        }
    }
}
