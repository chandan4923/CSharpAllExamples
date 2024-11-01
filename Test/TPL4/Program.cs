using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL4
{
    class Program
    {
        static void Main(string[] args)
        {

            Task tsk = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Task starting");

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Count is: " + i);
                }

                Console.WriteLine("Task terminating!");
            });
            tsk.Dispose();


            tsk.Wait();


        }
    }
}
