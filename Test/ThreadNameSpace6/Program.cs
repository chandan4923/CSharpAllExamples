using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace6
{

    class SharedRes
    {
        public static int Count = 0;

        public static Mutex mutex = new Mutex();
    }

    class IncrThread
    {
        public Thread thrd;
        public int num;
        public IncrThread(string name, int n)
        {
            num = n;
            thrd = new Thread(Run);

            thrd.Name = name;

            thrd.Start();
        }

        public void Run()
        {
            //SharedRes.mutex.WaitOne();

            Console.WriteLine("Calling " + thrd.Name);

            do
            {
                Thread.Sleep(500);

                SharedRes.Count++;

                Console.WriteLine("value of count is: "+SharedRes.Count+" in "+thrd.Name);
                num--;

            } while (num>0);
            //SharedRes.mutex.ReleaseMutex();

        }
    }

    class DecrThread
    {
        public Thread thrd;
        public int num;
        public DecrThread(string name, int n)
        {
            num = n;
            thrd = new Thread(Run);

            thrd.Name = name;

            thrd.Start();
        }

        public void Run()
        {

            //SharedRes.mutex.WaitOne();
            Console.WriteLine("Calling "+thrd.Name);
            do
            {
                Thread.Sleep(500);

                SharedRes.Count--;

                Console.WriteLine("value of count is: " + SharedRes.Count + " in " + thrd.Name);
                num--;

            } while (num > 0);

            //SharedRes.mutex.ReleaseMutex();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IncrThread incr = new IncrThread("Incremental Thread", 5);

            DecrThread decr = new DecrThread("Decremental Thread", 10);

            incr.thrd.Join();

            decr.thrd.Join();

        }
    }
}
