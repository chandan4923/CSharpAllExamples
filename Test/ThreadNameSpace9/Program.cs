using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace9
{

    class SharedRes
    {
       public static int count = 0;
    }
    class IncrThread
    {
        public Thread thrd;
    
        public IncrThread(string name)
        {
            thrd = new Thread(Run);

            thrd.Name = name;

            thrd.Start();
        }

        public void Run()
        {
            //SharedRes.mutex.WaitOne();

            Console.WriteLine("Calling " + thrd.Name);
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Increment(ref SharedRes.count);

                Console.WriteLine("value of count is: " + SharedRes.count + " in " + thrd.Name);

            }
            //SharedRes.mutex.ReleaseMutex();

        }
    }

    class DecrThread
    {
        public Thread thrd;
        
        public DecrThread(string name)
        {
           
            thrd = new Thread(Run);

            thrd.Name = name;

            thrd.Start();
        }

        public void Run()
        {

            //SharedRes.mutex.WaitOne();
            Console.WriteLine("Calling " + thrd.Name);
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Decrement(ref SharedRes.count);

                Console.WriteLine("value of count is: " + SharedRes.count + " in " + thrd.Name);

            }

            //SharedRes.mutex.ReleaseMutex();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            IncrThread incr = new IncrThread("Incremental Thread");

            DecrThread decr = new DecrThread("Decremental Thread");

            


        }
    }
}
