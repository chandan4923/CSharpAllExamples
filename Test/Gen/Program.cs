using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn
{

    class Gen<T>
    {
        T i;

        public Gen(T o)
        {
            i = o;
        }

        public T GetOb()
        {
            return i;
        }

        public void ShowType()
        {
            Console.WriteLine("The type of the object is: "+typeof(T));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gen<int> gob = new Gen<int>(110);

            Console.WriteLine(gob.GetOb());
            gob.ShowType();

            Gen<string> sob = new Gen<string>("Using generics for string type");
            Console.WriteLine(sob.GetOb());
            sob.ShowType();

        }
    }
}
