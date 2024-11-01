using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn11
{
    class Gen<T,V> where T:class
        where V : struct
    {
        T o1;
        V o2;

        public Gen(T t, V v)
        {
            o1 = t;
            o2 = v;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Gen<string, int> g1= new Gen<string, int>("CHANDAN", 141);

            Gen<bool, int> g2 = new Gen<bool, int>(true, 999);


        }
    }
}
