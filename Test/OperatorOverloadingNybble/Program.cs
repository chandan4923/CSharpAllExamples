using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingNybble
{
    class Nybble
    {
        int val;
        public Nybble()
        {
            val = 0;
        }

        public Nybble(int i)
        {
            val = i;
            val = val&0xF;
        }

        public static Nybble operator +(Nybble ob1, Nybble ob2)
        {
            Nybble result = new Nybble();

            result.val = ob1.val + ob2.val;
            result.val = result.val & 0xF;
            return result;
        }

        public static Nybble operator +(Nybble ob1, int ob2)
        {
            Nybble result = new Nybble();

            result.val = ob1.val + ob2;
            result.val = result.val & 0xF;
            return result;
        }

        public static Nybble operator +(int ob1, Nybble ob2)
        {
            Nybble result = new Nybble();

            result.val = ob1 + ob2.val;
            result.val = result.val & 0xF;
            return result;
        }

        public static Nybble operator ++(Nybble ob)
        {
            Nybble result = new Nybble();

            result.val = ob.val + 1;
            result.val = result.val & 0xF;

            return result;
        }

        public static bool operator >(Nybble ob1,Nybble ob2)
        {
            if (ob1.val > ob2.val) return true;
            else return false;
        }


        public static bool operator <(Nybble ob1, Nybble ob2)
        {
            if (ob1.val < ob2.val) return true;
            else return false;
        }

        public static implicit operator int(Nybble ob)
        {
            return ob.val ;
        }

        public static implicit operator Nybble(int i)
        {
            return new Nybble(i );
        }

        public void Show()
        {
            Console.WriteLine(val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nybble a = new Nybble(1);
            Nybble b= new Nybble(10);
            Nybble c = new Nybble();

            int k;
            c = a + b;

            a = 10 + b;

            Console.WriteLine("a is "+(int)a);
            Console.WriteLine("b is "+(int)b);
            Console.WriteLine("c is "+(int)c);

            if (a < b) Console.WriteLine("a is less than b");

            a += 5;

            Console.WriteLine("new a is "+(int)a);

            k = a * 2 + 3;

            Console.WriteLine("Result of a*2+3: "+k );

            a = 19;

            Console.WriteLine("Value of a =19 is "+(int)a);

            for(a=0; a < 10; a++)
            {
                Console.Write((int)a+" ");
            }
        }
    }
}
