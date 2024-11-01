using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncompatibleRef
{
    class X
    {
        public int a;
        public X(int i)
        {
            a = i;
        }
    }
    class Y:X
    {
        public int b;
        public Y(int i, int j):base(j)
        {
            b = i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            X x = new X(10);
            X x1;

            Y y = new Y(5,6);

            x1 = x;
            Console.WriteLine("Value of x1.a is "+x1.a);

            x1 = y;
            Console.WriteLine("Value of x1.a is "+x1.a);
            x1.a = 66;
            
        }
    }
}
