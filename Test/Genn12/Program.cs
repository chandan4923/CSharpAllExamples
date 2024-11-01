using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn12
{

    class MyClass
    {

    }

    class Gen<T>
    {
        T ob;

        public Gen()
        {
            ob = default(T);
        }
        public void GetValue()
        {
            Console.WriteLine(ob);
        }
        public T GetT()
        {
            return ob;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Gen<int> g = new Gen<int>();

            g.GetValue();

            Console.WriteLine(g.GetT());

            Gen<string> gs = new Gen<string>();
            gs.GetValue();
            Console.WriteLine(gs.GetT());


            Gen<MyClass> gC = new Gen<MyClass>();
            gC.GetValue();
            Console.WriteLine(gC.GetT());
        }
    }
}
