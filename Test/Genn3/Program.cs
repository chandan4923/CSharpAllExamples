using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn3
{
    class A 
    { 
        public void Hello()
    {
        Console.WriteLine("Hello!");
    }
    }

    class B:A
    {

    }
    class C
    {

    }

    class Test<T> where T : A
    {
        T obj;

        public Test(T o)
        {
            obj = o;
        }

        public void SayHello()
        {
            obj.Hello();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            Test<A> t1 = new Test<A>(a);

            t1.SayHello();

            Test<B> t2 = new Test<B>(b);
            t2.SayHello();

            Test<C> t3 = new Test<C>(c);

            t3.SayHello();
        }
    }
}
