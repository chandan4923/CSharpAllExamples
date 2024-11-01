using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event7
{

    class MyEVentArgs : EventArgs
    {
        public int EventNum;
    }
    delegate void EventHandler1(object sender, MyEVentArgs e);
    class MyEvent
    {
        static int count =0;
        public event EventHandler1 OnSomeEvent;

            public void SomeEvent()
        {
            MyEVentArgs myEVentArgs = new MyEVentArgs();
            
            if (OnSomeEvent != null)
            {
                myEVentArgs.EventNum = count++;
                OnSomeEvent(this, myEVentArgs);
            }
        }
    }
    class X
    {
        public void Handler(object sender, MyEVentArgs e)
        {
            Console.WriteLine("Event "+e.EventNum+" received by X object");

            Console.WriteLine("Source is "+sender);

            Console.WriteLine();
        }
    }

    class Y
    {
        public void Handler(object sender, MyEVentArgs e)
        {
            Console.WriteLine("Event " + e.EventNum + " received by Y object");

            Console.WriteLine("Source is " + sender);

            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            X x = new X();
            Y y = new Y();

            MyEvent myEvent =new MyEvent();

            myEvent.OnSomeEvent += x.Handler;
            myEvent.OnSomeEvent += y.Handler;

            myEvent.SomeEvent();
            myEvent.SomeEvent();
        }
    }
}
