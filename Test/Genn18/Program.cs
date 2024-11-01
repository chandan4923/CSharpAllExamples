using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn18
{
    class MyClass : IComparable<MyClass>, IEquatable<MyClass>
    {
        public int val;

        public MyClass(int x)
        {
            val = x;
        }
        public int CompareTo(MyClass other)
        {
            return this.val- other.val;
        }

        public bool Equals(MyClass other)
        {
            return val == other.val;
        }
        public override bool Equals(object obj)
        {
            if (obj is MyClass)
                return base.Equals((MyClass)obj);

            else
                return false;
        }
        public override int GetHashCode()
        {
            return val.GetHashCode();
        }
    }

    class CompareDemo
    {
        public static bool IsIn<T>(T what, T[] obs) where T: IEquatable<T>
        {
            for (int i = 0; i < obs.Length; i++)
            {
                if (obs[i].Equals(what))
                {
                    return true;
                }
            }
            
                return false;
        }

        public static bool InRange<T>(T what, T[] obs) where T : IComparable<T>
        {
            if(what.CompareTo(obs[0])<0|| what.CompareTo(obs[obs.Length - 1])>0)
            {
                return false;
            }

            return true;
        }
    //}
    //class Program
    //{
        static void Main(string[] args)
        {

            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            if(IsIn(2, nums))
            {
                Console.WriteLine("2 is found");
            }
            MyClass[] myClass = new MyClass[] { new MyClass(1), new MyClass(2), new MyClass(4), new MyClass(5), new MyClass(6), new MyClass(10) };

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Before assigning");
                Console.WriteLine(myClass[i].val);

                //myClass[i] myi = new MyClass(i*2);
                //Console.WriteLine("After assigning");
                //myClass[i].val = i * 2;

                //Console.WriteLine(myClass[i].val);
            }

          if(IsIn(new MyClass(2), myClass))
            {
                Console.WriteLine("True");
            }

            if (InRange(new MyClass(3), myClass))
            {
                Console.WriteLine("True");
            }



        }
    }
}
