using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn15
{
    delegate T delSomeOp<T>(T v);
    delegate int delSomeOp1(int v);

    class MyClass
    {
        static int Increase(int i)
        {
            i++;
            return i;
        }

        class Program
        {
            static void Main(string[] args)
            {
                delSomeOp<int> dsomop = new delSomeOp<int>(Increase);

                delSomeOp1 dsomop1 = Increase;

                Console.WriteLine(dsomop(21));

                Console.WriteLine(dsomop1(33));


            }
        }
    }
}
