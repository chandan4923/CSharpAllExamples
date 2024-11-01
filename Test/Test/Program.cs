using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MyClass
    {
        public int y;
        public MyClass()
            {
            y = 10;
            }

    }

    class CustomClass
    {
        public int x;
        public CustomClass(int i)
        {
            x = i;
        }
        
    }
    class ChkNum
    {
       


        public bool IsPrime(int x)
        {
            MyClass myClass = new MyClass();
            myClass.y = 10;
            if (x <= 1) return false;

            for (int i = 2; i < x/i; i++)
            {
                if ((x % i) == 0) return false;

            }

            return true;
        }

        public int LeastCommonFactor(int a, int b)
        {
            if (IsPrime(a) || IsPrime(b)) return 1;

            int max;

            max = a < b ? a : b;

            return 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();


            CustomClass customClass = new CustomClass(100);
            CustomClass customClass1 = new CustomClass(730);

            Console.WriteLine(customClass.x+" "+customClass1.x);

        }

    }
    }

