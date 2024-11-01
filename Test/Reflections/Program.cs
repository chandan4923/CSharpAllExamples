using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    class MyClass
    {
        int x, y;
        public MyClass(int i, int j)
        {
            x = i;y = j;
        }
        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            if(x<i & y > i)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Set(int a,int b)
        {
            x = a;y = b;
            Show();
        }
        public void Set(double a, double b)
        {
            x = (int)a; y = (int)b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("Values of x: {0} and y:{1}",x,y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);
            MyClass mc = new MyClass(1,2);
            int val;

            var mi = t.GetMethods();

            foreach(var m in mi)
            {
                var pi = m.GetParameters();
                
                if (m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(int))
                {
                    object[] arg = new object[2];
                    arg[0] = 2;
                    arg[1] = 8;

                    m.Invoke(mc, arg);
                }
                else if(m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(double))
                {
                    object[] arg = new object[2];
                    arg[0] = 19.235;
                    arg[1] = 28.3526;

                    m.Invoke(mc, arg);
                }
                else if(m.Name.Equals("Sum", StringComparison.Ordinal))
                {
                    val = (int)m.Invoke(mc, null);
                    Console.WriteLine("The Sum value is: "+val);
                }
                else if (m.Name.Equals("IsBetween", StringComparison.Ordinal))
                {
                    object[] arg = new object[1];
                    arg[0] = 14;
                    if ((bool)m.Invoke(mc,arg))
                    {
                        Console.WriteLine(arg[0]+" is between x and y");
                    }
                    else
                    {
                        Console.WriteLine(arg[0] + " is not in between x and y");
                    }
                }
                else if(m.Name.Equals("Show", StringComparison.Ordinal))
                {
                    m.Invoke(mc, null);
                }
            }
        }
    }
}
