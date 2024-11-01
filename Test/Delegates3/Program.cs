using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates3
{
    class X
    {
        public int val;
    }

    class Y:X
    {

    }
    delegate X ChangeDel(Y ob);

    class CoContraVariance
    {
        public static X IncrA(X ob)
        {
            X temp = new X();
            temp.val = ob.val + 1;
            return temp;
        }

        public static Y IncrB(Y ob)
        {
            Y temp = new Y();
            temp.val = ob.val + 2;
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CoContraVariance c = new CoContraVariance();
            ChangeDel cd = CoContraVariance.IncrA;
            //X x = new X();
            Y y = new Y();

            X x = cd(y);

            Console.WriteLine("value of val is:" +x.val);
            cd += CoContraVariance.IncrB;

            X xx = cd(y);
            Console.WriteLine("value of val is:" + xx.val);

            Console.WriteLine("value of val is:" + x.val);




        }
    }
}
