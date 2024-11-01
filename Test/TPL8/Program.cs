using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL8
{
    class Program
    {

        //static void MyMeth() {
        //    Console.WriteLine("MyMeth() has started running");
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("MyMeth1(), Value of count is: " + i);
        //        Thread.Sleep(500);
        //    }
        //}
        //static void MyMeth1() {
        //    Console.WriteLine("MyMeth1() has started running");
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("MyMeth1(), Value of count is: " + i);
        //        Thread.Sleep(500);

        //    }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread is starting");


            Parallel.Invoke(()=> {
                Console.WriteLine("MyMeth() has started running");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("MyMeth1(), Value of count is: " + i);
                    Thread.Sleep(500);
                }
            },
            ()=> {
                Console.WriteLine("MyMeth1() has started running");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("MyMeth1(), Value of count is: " + i);
                    Thread.Sleep(500);
                }
            });

            Console.WriteLine("Main thread is ending");
        }
    }
}
