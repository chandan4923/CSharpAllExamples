
#define TRAIL

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Att3
{

    class Test
    {
        [Obsolete("Trail1 cannot be used. Use Release method!", true)]
        [Conditional("TRAIL")]
        public void Trail1()
        {
            Console.WriteLine("TREAIL VERSION");
        }
        [Conditional("RELEASE")]
        public void Release()
        {
            Console.WriteLine("NOT FOR DISTRIBUTION");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Test t = new Test();

            t.Trail1();
            t.Release();
        }
    }
}
