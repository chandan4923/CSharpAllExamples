using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortCircuit
{

    class ThreeD
    {
        int x, y, z;
        public ThreeD()
        {
            x = y = z = 0;
        }

        public ThreeD(int x, int y,int z )
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static ThreeD operator &(ThreeD ob1, ThreeD ob2)
        {
            if ((ob1.x != 0 && ob1.y != 0 && ob1.z != 0) & (ob2.x != 0 && ob2.y != 0 && ob2.z != 0)) return new ThreeD(1, 1, 1);
            else return new ThreeD(0, 0, 0);
        }

        public static ThreeD operator |(ThreeD ob1, ThreeD ob2)
        {
            if ((ob1.x != 0 || ob1.y != 0 || ob1.z != 0) | (ob2.x != 0 || ob2.y != 0 || ob2.z != 0)) return new ThreeD(1, 1, 1);
            else return new ThreeD(0, 0, 0);
        }

        public static bool operator true(ThreeD ob)
        {
            if (ob.x != 0 || ob.y != 0 || ob.z != 0) return true;
            else return false;
        }
        public static bool operator false(ThreeD ob)
        {
            if (ob.x == 0 && ob.y == 0 && ob.z == 0) return false;
            else return true;
        }

        public static ThreeD operator !(ThreeD ob)
        {
            return new ThreeD(-ob.z, -ob.y, -ob.z);
        }

        public void Show()
        {
            Console.WriteLine("Values of the object" +x+","+y+","+z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD ob1 = new ThreeD(4, 6, 7);
            ThreeD ob2 = new ThreeD(10, 10, 10);
            ThreeD ob3 = new ThreeD(0, 0, 0);

            if (ob1 & ob2) Console.WriteLine("ob1 and ob2 are true");
            else Console.WriteLine("ob1 and ob2 are false");

            if (ob1 & ob3) Console.WriteLine("ob1 and ob3 are true");
            else Console.WriteLine("ob1 and ob3 are false");

            if (ob3 & ob2) Console.WriteLine("ob3 and ob2 are true");
            else Console.WriteLine("ob3 and ob2 are false");

            if (ob1 | ob2) Console.WriteLine("ob1 or ob2 are true");
            else Console.WriteLine("ob1 or ob2 are false");

            if (ob1 | ob3) Console.WriteLine("ob1 or ob3 are true");
            else Console.WriteLine("ob1 or ob3 are false");

            if (ob3 | ob2) Console.WriteLine("ob3 or ob2 are true");
            else Console.WriteLine("ob3 or ob2 are false");

            if (ob1 && ob2) Console.WriteLine("ob1 && ob2 are true");
            else Console.WriteLine("ob1 and ob2 are false");

            if (ob1 && ob3) Console.WriteLine("ob1 && ob3 are true");
            else Console.WriteLine("ob1 and ob3 are false");

            if (ob3 && ob2) Console.WriteLine("ob2 && ob3 are true");
            else Console.WriteLine("ob2 and ob3 are false");

            if (ob1 || ob2) Console.WriteLine("ob1 || ob2 are true");
            else Console.WriteLine("ob1 or ob2 are false");

            if (ob1 || ob3) Console.WriteLine("ob1 || ob3 are true");
            else Console.WriteLine("ob1 or ob3 are false");

            if (!ob1) Console.WriteLine("ob1 is false");
            if (!ob2) Console.WriteLine("ob2 is false");
            if (!ob3) Console.WriteLine("ob3 is false");

        }
    }
}
