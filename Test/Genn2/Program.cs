using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn2
{
    class TwoGen<T, V>
    {
        T t;
        V v;

        public TwoGen(T i, V s)
        {
            t = i;
            v = s;
        }

        public T Gett()
        {
            return t;
        }
        public V Getv()
        {
            return v;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TwoGen<int, string> twoGen = new TwoGen<int, string>(111, "Alpha Beta Gamma");

            int i = twoGen.Gett();
            string s = twoGen.Getv();

            Console.WriteLine("Integer and string values are: "+i+" "+s);
        }
    }
}
