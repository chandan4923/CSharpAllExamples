using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn8
{
    class MyClass
    {
        public void Write()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Test<T> where T : class
    {
        T ob;

        public Test(T input)
        {
            ob = input;
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
            MyClass mc = new MyClass();

            Test<MyClass> tmc = new Test<MyClass>(mc);

            tmc.GetT().Write();
        }
    }
}
