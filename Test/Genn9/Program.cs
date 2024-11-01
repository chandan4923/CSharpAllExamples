using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn9
{
    struct myStruct
    {

    }
    class myClass
    {

    }

    class Test<T> where T : struct
    {
        T ob;
        public Test(T o)
        {
            ob = o;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test<myStruct> myS = new Test<myStruct>(new myStruct());


            Test<int> myS1 = new Test<int>(10);



        }
    }
}
