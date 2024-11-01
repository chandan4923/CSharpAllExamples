using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadNameSpace5
{
    class TickTock
    {
        object lockon = new object();

        public void Tick(bool running)
        {

            lock (lockon)
            {
                if (!running)
                {
                    Monitor.Pulse(lockon);
                    return;
                }

                Console.Write("Tick ");

                Monitor.Pulse(lockon);
                Monitor.Wait(lockon);
            }
        }

        public void Tock(bool running)
        {
            lock (lockon)
            {
                if (!running)
                {
                    Monitor.Pulse(lockon);
                    return;
                }

                Console.Write("Tock\n");

                Monitor.Pulse(lockon);
                Monitor.Wait(lockon);
            }
        }
    }

    class MyTHread
    {
        public Thread thrd;

        TickTock tickTock = new TickTock();
        public MyTHread(string name)
        {
            thrd = new Thread(Run);
            thrd.Name = name;

            thrd.Start();
            
        }

        public void Run()
        {
            
            if (thrd.Name.ToLower() == "tick")
            {
                for (int i = 0; i < 5; i++)
                {
                    
                    tickTock.Tick(true);
                }

                tickTock.Tick(false);
            }
            else if (thrd.Name.ToLower() == "tock")
            {
                for (int i = 0; i < 5; i++)
                {
                        tickTock.Tock(true);
                }

                tickTock.Tock(false);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyTHread myT = new MyTHread("tick");
            MyTHread myT1 = new MyTHread("tock");

            myT.thrd.Join();
            myT1.thrd.Join();
        }
    }
}
