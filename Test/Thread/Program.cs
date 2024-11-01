using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadNameSpace
{

    class MYThread
    {

        public int count;
        public Thread thread;
        public MYThread(string name)
        {
            count = 0;
             thread = new Thread(this.Run);

            thread.Name = name;

            thread.Start();
        }

        public void Run()
        {
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In "+thread.Name+", Count is "+count);
                count++;


            } while (count<10);

            Console.WriteLine(thread.Name+" terminating");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MYThread mythread1 = new MYThread("Child #1");
            MYThread mythread2 = new MYThread("Child #2");
            MYThread mythread3 = new MYThread("Child #3");

            //mythread1.thread.Join();
            Console.WriteLine("Child #1 joined");


            //mythread1.thread.Join();
            Console.WriteLine("Child #2 joined");


            //mythread1.thread.Join();
            Console.WriteLine("Child #3 joined");




            //do
            //{
            //    Console.Write(".");
            //    Thread.Sleep(100);

            //} while (mythread1.thread.IsAlive || mythread2.thread.IsAlive || mythread3.thread.IsAlive);

            //Console.WriteLine("Main thread ending!");
        }
    }
}
