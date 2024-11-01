using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace4
{
    class SumArray
    {
        int sum;
        object lockOn = new object();

        public int SumIt(int[] nums)
        {
            {
                sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];

                    Console.WriteLine("Running total for " + Thread.CurrentThread.Name + " is:" + sum);

                    Thread.Sleep(10);
                }
                return sum;

            }
        }
    }
    class MyThread
    {
        public Thread thrd;

        int[] a;

        int answer;

        SumArray sa = new SumArray();
        static object obj = new object();
        public MyThread(string name, int[] nums)
        {
            thrd = new Thread(this.Run);
            thrd.Name = name;
            a = nums;
            thrd.Start();
        }

        public void Run()
        {

         
            lock (obj)
            {

                Console.WriteLine(thrd.Name + " is starting!");


                answer = sa.SumIt(a);

                Console.WriteLine("Sum for " + thrd.Name + " is " + answer);

                Console.WriteLine(thrd.Name + " is terminating!");


            }

        }
        class Program
        {
            public static void Main(string[] args)
            {
                int[] a = { 1, 2, 3, 4, 5 };

                MyThread myThread = new MyThread("Child #1", a);
                MyThread myThread1 = new MyThread("Child #2", a); ;



                //object lockon = new object();




                //myThread1.thrd.Priority = ThreadPriority.Highest;
                //    myThread1.thrd.Join();
                //myThread.thrd.Join();

            }
        }
    }
}
