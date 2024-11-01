using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c = TestNameSpace;

namespace TestNameSpace
{
    class Chandan
    {
        public void CHandanMethod()
        {
            Console.WriteLine("Chandan class from TestNameSpace");
        }
    }
    class MyCount
    {
        public void Counter()
        {
            Console.WriteLine("This is counter method");
        }
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //}
    }

    namespace TestNameSpace.NS2
    {
        class B
        {
            public B()
            {
                Console.WriteLine("Constructing B!");
            }
        }
    }
}
namespace TestNameSpace.NS3
{ 
 class Chandan
    {
        public void ChandanMethod()
        {
            Console.WriteLine("This is CHandan Method");
        }
    }

}

class Chandan
{
    public void Method1()
    {
        Console.WriteLine("Method1 from Global Namespace");
    }
}

    class Demo
{
    static void Main()
    {
        TestNameSpace.MyCount Tmc = new TestNameSpace.MyCount();
        Tmc.Counter();
        TestNameSpace.NS3.Chandan Tc = new TestNameSpace.NS3.Chandan();
        Tc.ChandanMethod();

        TestNameSpace.TestNameSpace.NS2.B b = new TestNameSpace.TestNameSpace.NS2.B();


        c::Chandan cc = new c::Chandan();
        cc.CHandanMethod();
        global::Chandan cd = new global::Chandan();
        cd.Method1();   
    
    }
}
