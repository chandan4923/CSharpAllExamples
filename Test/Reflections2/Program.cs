using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assm = Assembly.LoadFrom("Reflections1.exe");

          Type[] alltypes=  assm.GetTypes();

            foreach(var t in alltypes)
            {
                Console.WriteLine(t.Name);

                foreach (var q in t.GetConstructors())
                {
                    foreach (var x in q.GetParameters())
                    {
                        Console.Write("Constructor Name: " + x.ParameterType.Name+" ");
                        Console.Write(x.Name+"\r\n");

                    }

                }
            }
        }
    }
}
