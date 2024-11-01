using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn16
{
    public interface Iseries<T>
    {
        T GetNext();
        void Reset();
        void SetStart(T v);
    }

    class Two<T> : Iseries<T>
    {
        T start;
        T val;

        public delegate T IncByTwo(T v);

        IncByTwo inctwo;

        public Two(IncByTwo i)
        {
            start = default(T);

            val = default(T);

            inctwo = i;
        }

        public T GetNext()
        {
            val = inctwo(val);
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(T v)
        {
            start = v;

            val = start;

        }
    }

    class IntFDemo
    {
        public static int IntPlusTwo(int i)
        {
            int v = i;
            v = v + 2;
            return v;
        }

        public int IncreaseByOne(int i)
        {

            return ++i;
        }

        public static ThreeD  THreeDPlusTwo(ThreeD v)
        {
            if (v == null)
            {
                return new ThreeD(0, 0, 0);
            }
            else
            {
                return new ThreeD(v.x + 2, v.y + 2, v.z + 2);
            }
        }
    }

    class ThreeD
    {
        public int x, y, z;

        public ThreeD(int a , int b , int c)
        {
            x = a;
            y = b;
            z = c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Two<int> t = new Two<int>(IntFDemo.IntPlusTwo);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(t.GetNext());
            }

            IntFDemo intFDemo = new IntFDemo();
            Two<int> t1 = new Two<int>(intFDemo.IncreaseByOne);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(t1.GetNext());
            }

            ThreeD td = new ThreeD(1,2,3);

            IntFDemo intFDemo2 = new IntFDemo();

            

            Two<ThreeD> two = new Two<ThreeD>(IntFDemo.THreeDPlusTwo);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(two.GetNext().x+" "+two.GetNext().y+" "+two.GetNext().z);
            }


        }
    }
}
