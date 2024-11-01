using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOut
{
    class Decompose
    {
        public int GetParts(double n, out double frac)
        {
            int whole;

            whole = (int)n;
            frac = n - whole;

            return whole;
        }
    }
    class Num
    {
        public bool HasCommonFactor(int i, int j, out int LCF, out int GCF)
        {
            int max = i < j ? i : j;
            bool s = true;
           GCF= LCF = 1;

            for(int k=2; k<(max/2+1); k++)
            {
                if(i%k==0&j%k==0)
                {
                    if (s)
                    {
                        LCF = k;
                        s = false;
                    }
                    GCF = k;
                }
            }
            if (LCF != 1) return true;
            else return false;
        }
    }

    class RefSwap
    {
        int a, b;
        public RefSwap(int i, int j)
        {
            a = i;
            b = j;
        }
        public void Show()
        {
            Console.WriteLine("Value of A and B is: "+a+" "+b);
        }
        public void Swap( RefSwap ob1, RefSwap ob2)
        {
            RefSwap t;
            t = ob1;
            ob1 = ob2;
            ob2 = t;
        }
    }

    class Min
    {
        public int MinOf(out string msg, params int[] numbers)
        {
            int m;
            if (numbers.Length == 0)
            {
                //Console.WriteLine("The number of arguments passed cannot be zero");
                msg = "The number of arguments passed cannot be zero";
                return 0;
            }
            else
            {
                msg = $"The Length of number is: "+numbers.Length;
                m = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (m > numbers[i]) m = numbers[i];
                }
                return m;
            }
            
            
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //double f;
            //Decompose decompose = new Decompose();
            //int i =decompose.GetParts(10.112, out f);

            //Console.WriteLine("Integer part is "+i);
            //Console.WriteLine("Fraction part is "+f);

            // Num num = new Num();
            //if( num.HasCommonFactor(51, 35, out int L, out int G))
            // Console.WriteLine("LCF: "+L+" and GCF: "+G);
            //else
            //     Console.WriteLine("It has no common factor");

            //RefSwap R1 = new RefSwap(10, 44);
            //RefSwap R2 = new RefSwap(22, 76);

            //R1.Show();
            //R2.Show();

            //R1.Swap(R1, R2);

            //Console.WriteLine("After Swap, values are as below:");

            //R1.Show();
            //R2.Show();

            Min min = new Min();
            //Console.WriteLine("Minimum of numbers is: "+(min.MinOf(13, 4, 2, 7, 5,-2)));

           int j = min.MinOf(out string f, 13, 4, 2, 7, 5, -2);
            Console.WriteLine(f+ " "+j);

        }
    }
}
