using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace7
{

    class MyThread
    {
        public Thread thread;
        public MyThread(string name)
        {
            thread = new Thread(Run);

            thread.Name = name;

            thread.Start();
        }

        static Semaphore sem = new Semaphore(3,3);
        void Run()
        {
            Console.WriteLine(thread.Name +" is waiting for permit!");

            sem.WaitOne();

            Console.WriteLine(thread.Name +" is acquiring permit!");

            for (char i = 'A'; i < 'D'; i++)
            {
                Console.WriteLine(thread.Name +" " +i+" ");
                Thread.Sleep(500);
            }

            Console.WriteLine(thread.Name + " is releasing permit!");

            sem.Release();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyThread mt = new MyThread("Class #1");
            MyThread mt1 = new MyThread("Class #2");
            MyThread mt2 = new MyThread("Class #3");


            mt.thread.Join();
            mt1.thread.Join();
            mt2.thread.Join();
        }
    }
}
