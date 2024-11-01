using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace RTTID2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(StreamReader);

            Console.WriteLine(t.FullName);
            if (t.IsClass) Console.WriteLine("t is of type class");
            else if (t.IsAbstract) Console.WriteLine("t is of type abstract");
            else
            {
                Console.WriteLine("t is concrete");
            }
            
            MethodInfo
        }
    }
}
