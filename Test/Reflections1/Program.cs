using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections1
{
    class MyClass
    {
        int x, y;
        public MyClass(int i)
        {
            x = y = i;
            Console.WriteLine("Construncting MyClass(int,int)");
        }
        public MyClass(int i, int j)
        {
            x = i; y = j;
            Console.WriteLine("Construncting MyClass(int,int)");
            Show();
        }
        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            if (x < i & y > i)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Set(int a, int b)
        {
            x = a; y = b;
            Show();
        }
        public void Set(double a, double b)
        {
            x = (int)a; y = (int)b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("Values of x: {0} and y:{1}", x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);

            ConstructorInfo[] ci = t.GetConstructors();

            foreach(var c in ci)
            {
                Console.Write(t.Name+"(");

                ParameterInfo[] pi = c.GetParameters();

                for(int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name+" "+pi[i].Name);
                    if (pi.Length > i + 1)
                    {
                        Console.Write(",");
                    }
                    else
                    {
                        Console.Write(")\r\n");
                    }
                }
                int x;
                for ( x = 0; x < ci.Length; x++)
                {
                    ParameterInfo[] cpi = ci[x].GetParameters();
                    if (cpi.Length == 2) break;
                }
                if (x == 2)
                {
                    Console.WriteLine(" two paramter constructor not found");
                }
                else
                {
                    Console.WriteLine("Two parameter constructor found");
                }

                object[] oj = new object[2];
                oj[0] = 10;
                oj[1] = 340;
                object obj = ci[x].Invoke(oj);

                MethodInfo[] MI = t.GetMethods();

                foreach (var X in MI)
                {
                    if (X.Name.Equals("Sum", StringComparison.Ordinal))
                    {
                        object[] o = new object[2];
                        o[0] = 90;
                        o[1] = 81;
                        Console.WriteLine(X.Invoke(obj, null));
                        break;
                }
                }

            }
        }
    }
}
