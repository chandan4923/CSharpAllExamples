using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflctions
{
    class MyClass
    {
        int x;
        int y;

        public MyClass(int i , int j)
        {
            x = i;
            y = j;
        }

        public int Sum()
        {
            return x + y;
        }

        public bool InBetween(int i)
        {
            if (x < i && y > i)
            {
                return true;
            }
            else return false;
        }
        public void Set(int a , int b)
        {
            x = a;
            y = b;
        }
        public void Set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }
        public void Show()
        {
            Console.WriteLine("x: {0},y: {1}",x,y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);
            Console.WriteLine("Methods Supported\r\n");

            MethodInfo[] mi = t.GetMethods(BindingFlags.DeclaredOnly| BindingFlags.Public|BindingFlags.Instance);

            foreach (var i in mi)
            {
                Console.Write(i.ReturnType.Name+" "+i.Name+"(");
                ParameterInfo[] pi = i.GetParameters();
                for (int j = 0; j < pi.Length; j++)
                {
                    Console.Write(pi[j].ParameterType.Name+" "+pi[j].Name);
                    if (j + 1 < pi.Length) Console.Write(",");
                }
                Console.Write(") \r\n");
            
            }

          
        }
    }
}
