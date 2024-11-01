using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructors
{
    class Cons
    {
        public static int alpha;
        public int beta;
        static Cons()
        {
            alpha = 99;
            Console.WriteLine("Inside Static COnstructor");
        }
        public Cons()
        {
            beta = 100;
            Console.WriteLine("Inside non-static constructor");
        }
    }

    static class NumericFn
    {
        public static double Reciprocal(double num)
        {
            return 1 / num;
        }
        public static double FractionPart(double i)
        {
            return i - (int)i;
        }
        public static bool IsEven(double num)
        {
            return (num % 2) == 0 ? true : false;
        }
        public static bool IsOdd(double j)
        {
            return !IsEven(j);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Cons cons = new Cons();
            //Console.WriteLine("Value of alpha is " + Cons.alpha);
            //Console.WriteLine("Value of beta is "+cons.beta);
            Console.WriteLine("Reciprocal of 5 is "+NumericFn.Reciprocal(5.0));
            Console.WriteLine("Fractional part of 8.12546 is "+NumericFn.FractionPart(8.12546));

            if(NumericFn.IsEven(10))
            Console.WriteLine("10 is even");

            if (NumericFn.IsOdd(9)) { Console.WriteLine("9 is odd number"); }
        }
    }
}
