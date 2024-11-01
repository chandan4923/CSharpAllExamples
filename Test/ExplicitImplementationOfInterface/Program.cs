using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitImplementationOfInterface
{
    interface IEven
    {
        bool IsEven(int x);
        bool IsOdd(int x);
    }

    class MyClass : IEven
    {
        bool IEven.IsEven(int x)
        {
            if (x != 0)
            {
                return x % 2 == 0 ? true : false;
            }
            else
            {
                Console.WriteLine("Zero cannot be entered");
                return false;
            }

        }

        public bool IsOdd(int x)
        {
            if (x != 0)
            {
                return x % 2 != 0 ? true : false;
            }
            else
            {
                Console.WriteLine("Zero cannot be entered");
                return false;
            }
        }
    }

    interface IMyIF_A
    {
        int Meth(int x);
    }
    interface IMyIF_B
    {
        int Meth(int x);
    }

    class MC : IMyIF_A, IMyIF_B
    {
        int IMyIF_A.Meth(int x)
        {
            return x * x;
        }

        int IMyIF_B.Meth(int x)
        {
            return x + x;
        }

        public int Multiply(int x)
        {
            IMyIF_A oA = this;
            return oA.Meth(x);
        }

        public  int Add(int x)
        {
            MC mc = new MC();
            IMyIF_B oB = mc;
            return oB.Meth(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass m = new MyClass();

            //IEven IE;

            //IE = m;

            //if (IE.IsEven(6))
            //{
            //    Console.WriteLine("6 is Even Number");
            //}
            //if (m.IsOdd(0))
            //{
            //    Console.WriteLine("0 is odd number");
            //}

            //if (IE.IsOdd(9))
            //{
            //    Console.WriteLine("9 is odd number");
            //}

            MC m = new MC();
            int x = 10;

            Console.WriteLine("Multiplied value of "+x+": "+m.Multiply(10));


            Console.WriteLine("Addition value of "+x+": "+m.Add(10));


        }
    }
}
