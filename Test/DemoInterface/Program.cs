using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    interface ISeries
    {
        

        int GenNext();
        void Reset();
        void SetStart(int x);

    }

    class ByTwos : ISeries
    {
        int val, start, prev;
        
        public ByTwos()
        {
            val = 0;
            start = 0;
            prev = -2;
        }
        public int GenNext()
        {
            prev = val;
            val += 2;
            return val;
        }

        public void Reset()
        {
            
            val = start;
            prev = start - 2;
        }

        public void SetStart(int x)
        {

            start = x;
            val = start;
            prev = val - 2;
        }
        public int GetPrev()
        {
            return prev;
        }

    }
    class Primes : ISeries
    {
        int val, start;
        public Primes()
        {
            val = 2;
            start = 2;
        }
        public int GenNext()
        {
            val++;
            bool IsPrime;

            for (int i = val; i < 100000; i++)
            {
                IsPrime = true;
                for (int j = 2; j <= i/j; j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    val = i;
                    break;
                }
            }
            return val;
            
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ByTwos ob = new ByTwos();
            Primes obP = new Primes();
            ISeries IObP;

            for (int i = 0; i < 5; i++)
            {
                IObP = ob;
                
                Console.WriteLine("Value of next is: "+ob.GenNext());
                IObP = obP;
                Console.WriteLine("Value of next is: "+IObP.GenNext());

            }

            
            //ob.Reset();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Value of next is: " + ob.GenNext());
            //}
            //ob.SetStart(100);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Value of next is: " + ob.GenNext());
            //}

        }
    }
}
