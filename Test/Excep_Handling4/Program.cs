using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep_Handling4
{
    class X 
    {
        int x;
        public X(int a)
        {
            x = a;
        }
        public int Add(X o)
        {
            return x + o.x;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            X a = new X(10);

            X b = null; 
            try
            {
                a.Add(b);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Caught Null Reference Exception");
                Console.WriteLine("Fixing null reference\n");

                b = new X(45);

                
            }

            Console.WriteLine(a.Add(b));
        }
    }
}
