using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeArrayNS
{

    class RangeArray
    {
        int upperBound, lowerBound;
        int[] a;

        public int _length { private set; get; }

        public bool _error { private set; get; }

        private bool OK(int index)
        {
            if (index >= lowerBound & index <=upperBound) return true;
            else return false;
        }

        public RangeArray(int lB, int uB)
        {
            
            if (lB < uB)
            {
                upperBound = uB;
                lowerBound = lB;
                upperBound++;
                _length = upperBound - lowerBound;
                a = new int[_length];
                upperBound--;
            }
            else
            {
                upperBound = 1;
                lowerBound = 0;
            }
        }

        public int this[int index]
        {
            set
            {
                if (OK(index))
                {
                    _error = false;
                     a[index - lowerBound] = value;
                }
                else
                {
                    _error = true;
                }
               
            }
            get
            {
                if (OK(index)) 
                { 
                 _error = false;
                return a[index - lowerBound]; 
                }
                else _error = false; return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            RangeArray ra = new RangeArray(-5, 5);
            RangeArray ra2 = new RangeArray(1, 10);
            RangeArray ra3 = new RangeArray(-20,-12);

            for (int i = -5; i <= 5; i++)
            {
                ra[i] = i;
            }
            Console.WriteLine("Contents of ra:");
            for (int i = -5; i <= 5; i++)
            {
                Console.Write(ra[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Length of ra1 is: "+ra._length);
            
            for (int i = 1; i <10; i++)
            {
                ra2[i] = i;
            }
            Console.WriteLine("Contents of ra2:");
            for (int i = 1; i < 5; i++)
            {
                Console.Write(ra2[i] + " ");
            }
            Console.WriteLine();
            for (int i = -20; i < -12; i++)
            {
                ra3[i] = i;
            }
            Console.WriteLine("Contents of ra3:");
            for (int i = -20; i < -12; i++)
            {
                Console.Write(ra3[i] + " ");
            }
        }
    }
}
