using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn20
{

    class NonGen
    {
        int num;
        public NonGen(int i)
        {
            num = i;
        }

        public int GetNum()
        {
            return num;
        }
    }

    class Gen<T> : NonGen
    {
        public T ob;
        public Gen(int i, T o) : base(i)
        {
            ob = o;
        }
        public T Getob()
        {
            return ob;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gen<string> gen = new Gen<string>(12, "Chandan");


            Console.WriteLine( gen.Getob()+" "+gen.GetNum());
        }
    }
}
