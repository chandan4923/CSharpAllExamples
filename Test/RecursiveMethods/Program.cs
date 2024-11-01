using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
class Recursive
    {
        public int FactR(int n)
        {
            int result;

            if (n == 1 || n==0)
            {
                return 1;
            }
            else
            {
                return result = FactR(n - 1) * n;

            }
            
        }
        public int FactI(int t)
        {
            int result=1;
            
            for (int i=1; i<=t;i++)
            {
                if (t == 0)
                {
                    result = 1;
                }
                else
                {
                    result = result * i;
                }
            }
            return result;
        }
    }

    class RevStr
    {
        public void Rev(string s)
        {

            if (s.Length > 0)
            {
                Rev(s.Substring(1, s.Length - 1));
                
            }
            else return;
            Console.Write(s[0]);
        }
    }
    class StaticDemo
    {
        public static int v = 100;
        public int i = 9;

        public static int Val()
        {
            StaticDemo s = new StaticDemo();
            return v / s.i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string c = "Chandan is";

            //Recursive r = new Recursive();
            //Console.WriteLine(r.FactI(0));
            //Console.WriteLine(r.FactI(3));


            //Console.WriteLine(r.FactR(0));
            //Console.WriteLine(r.FactR(3));

            //RevStr R = new RevStr();
            //R.Rev(c);
            //Console.WriteLine();

            Console.WriteLine(StaticDemo.v);

            StaticDemo.v = 8;
            Console.WriteLine(StaticDemo.v);

            Console.WriteLine(StaticDemo.Val());
        }
    }
}
