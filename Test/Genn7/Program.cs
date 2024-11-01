using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn7
{

    class MyClass
    {
        //public MyClass()
        //{

        //}
    }

    class Test<T> where T : new()
    {
        T o;
        public Test()
        {
            o = new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
