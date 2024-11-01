using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep_Handling5
{
    class RangeIndexer
    {
        int upperLimit, lowerLimit;

        public int Length { get; private set; }
        int[] a;

        public RangeIndexer(int l, int u)
        {
            u++;
            if (l >= u)
            {
                //throw new RangeArrayExceptions("Lower Limit cannot be greater than or equal to Upper Limit");
                throw new RangeArrayExceptions();
            }
            else
            {
                lowerLimit = l;
                

                Length = u - l;

                a = new int[Length];
                u--;
                upperLimit = u;

            }
        }

        public int this[int index]
        {
            set
            {
                if (OK(index))
                {
                    a[index - lowerLimit] = value;
                }
                else
                {
                    //throw new RangeArrayExceptions("Index value of the Indexxer should be within/equal to upper and lower limit");
                    throw new RangeArrayExceptions();
                }
            }

            get
            {
                if (OK(index))
                    return a[index - lowerLimit];
                else
                {
                    throw new RangeArrayExceptions();
                    //throw new RangeArrayExceptions("Index value of the Indexxer should be within/equal to upper and lower limit");
                }

            }
        }
        public bool OK(int index)
        {
            if (index >= lowerLimit && index <= upperLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
    public class RangeArrayExceptions : Exception
    {
        public RangeArrayExceptions() : base()
        {
            throw new RangeArrayExceptions("Error will be every where");
        }
        public RangeArrayExceptions(string message) : base(message)
        {

        }
        public RangeArrayExceptions(string message, Exception innerException) : base(message, innerException)
        {

        }
        public RangeArrayExceptions(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {

        }
        //public override string ToString()
        //{
        //    return Message;
        //}
        class Program
        {
            static void Main(string[] args)
            {
                RangeIndexer ra1 = new RangeIndexer(-5, 5);
                RangeIndexer ra2 = new RangeIndexer(1, 10);

                Console.WriteLine("Length of ra1: " + ra1.Length);

                for (int i = -5; i <= 5; i++)
                {
                    ra1[i] = i;
                }
                for (int i = -5; i < 5; i++)
                {
                    Console.WriteLine(ra1[i] + " ");
                }


                //Demonstration ra2

                Console.WriteLine("Length of ra: " + ra1.Length);

                for (int i = 1; i <= 10; i++)
                {
                    ra2[i] = i;
                }
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(ra2[i] + " ");
                }


                try
                {
                    RangeIndexer ra3 = new RangeIndexer(100, -1);

                }
                catch (RangeArrayExceptions ex)
                {
                    Console.WriteLine(ex);
                }

                try
                {
                    RangeIndexer ra3 = new RangeIndexer(-2,2);
                    for (int i = -2; i <=2; i++)
                    {
                        ra3[i] = i;
                    }

                    for (int i = -2; i <=10; i++)
                    {
                        Console.WriteLine(ra3[i]);
                    }

                }
                catch (RangeArrayExceptions ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
