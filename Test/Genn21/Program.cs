using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn21
{

    class Gen<T>
    {
        protected T ob;
        public Gen(T o)
        {
            ob = o;
        }
        public virtual T GetOb()
        {
            Console.WriteLine("Gen's GetOb(): ");
            return ob;
        }
    }

    class Gen1<T>:Gen<T>
    {
        //public T ob1
        public Gen1(T ob1):base(ob1)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
