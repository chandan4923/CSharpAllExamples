using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailSafeArrayIndexer
{

    class FailSafe
    {
        public int Count { private get; set; }
        public string Str { get; set; }
        int[] a;

        public int length { private set; get; }
        public bool ErrFlag { private set; get; }

        public FailSafe(int size)
        {
            a = new int[size];
            length = size;
        }
        //public int ReadonlyLenght
        //{
        //    get
        //    {
        //        return length;
        //    }
        //}
        public int this[int index]
        {
            set
            {
                if (Ok(index))
                { a[index] = value; ErrFlag = false; }
                else ErrFlag = true;
            }

            get
            {
                if (Ok(index))
                {
                    ErrFlag = false;
                    return a[index];

                }

                else
                {
                    ErrFlag = true;
                    return 0;

                }
            }
        }

        public int this[double ifx]
        {
            
            get
            {
                int index;
                if ((ifx - (int)ifx) < 0.5)
                { index = (int)ifx; }
                else index =(int)ifx+1;

                if (Ok(index))
                {
                    ErrFlag = false;
                    return a[index];
                }
                else
                {
                    ErrFlag = false;
                    return 0;
                }

            }
            set
            {
                int index;
                if (ifx - (int)ifx < 0.5) index = (int)ifx;
                else index = (int)ifx + 1;

                if (Ok(index))
                { a[index] = value; ErrFlag = false; }
                else ErrFlag = true;

            }

        }

        private bool Ok(int i)
        {
            if (i >= 0 & i < length) return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            FailSafe F = new FailSafe(5);

            FailSafe F1 = new FailSafe(6) { Count = 98, Str = "CHandan" };
          
            int x;

            for(int i =0; i < F.length; i++)
            {
                F[i] = 10 * i;
            }

            for(int i=0; i < F.length; i++)
            {
                x = F[i];

                if (x >= 0) Console.WriteLine("value of x is: "+x);
            }

            for (int i = 0; i < F.length; i++)
            {
                F[i] = 10 * i;

                if (F.ErrFlag) Console.WriteLine("Value of index"+i+" is out of bound");
            }
            Console.WriteLine("F[1.45] value is: "+F[1.45]);
            for (int i = 0; i < F.length; i++)
            {
                x = F[i];

                if (F.ErrFlag) Console.WriteLine("Value of index" + i + " is out of bound");
            }

        }
    }
}
