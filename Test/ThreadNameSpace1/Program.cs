using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace1
{
    class MYThread
    {

        public int count;
        public Thread thread;
        public MYThread(string name, int num)
        {
            count = 0;
            thread = new Thread(this.Run);

            thread.Name = name;

            thread.Start(num);
        }

        public void Run(object num)
        {

            Console.WriteLine(thread.Name+" starting with count of "+num);
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In " + thread.Name + ", Count is " + count);
                count++;


            } while (count < (int)num);

            Console.WriteLine(thread.Name + " terminating");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MYThread mythread1 = new MYThread("Child #1", 5);
            MYThread mythread2 = new MYThread("Child #2",3);

            do
            {
                Thread.Sleep(100);
            } while (mythread1.thread.IsAlive||mythread1.thread.IsAlive);
        }
    }
}
