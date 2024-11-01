using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOperator
{
    class TD {
        int x, y, z;
        public TD()
        {
            x = y = z = 0;
        }

        public TD(int x,int y, int z)
        {
            this.x = x;
            this.y = y;
                this.z= z;
        }

        public static TD operator +(TD ob1, TD ob2)
        {
            return new TD(ob1.x + ob2.x, ob1.y + ob2.y, ob1.z + ob2.z);
        }


        //Implicit Conversion
        //public static implicit operator int(TD ob)
        //{
        //    return ob.x * ob.y * ob.z;
        //}
        public static explicit operator int(TD ob)
        {
            return ob.x * ob.y * ob.z;
        }

        public void SHow()
        {
            Console.WriteLine(x+" "+y+" "+z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TD a = new TD(1, 2, 3);
            TD b = new TD(10, 10, 10);
            TD c = new TD(0, 0, 0);

            int i;

            a.SHow();

            b.SHow();

            c.SHow();

            c = a + b;

            Console.WriteLine("Result of a +b: ");
            c.SHow();

            i =(int) a;

            Console.WriteLine("Result of i =1: "+i);


            i = (int)a * 2 - (int)b;
            Console.WriteLine("Result of i =a*2-b: " + i);
        }
    }
}
