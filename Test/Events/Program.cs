using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    delegate void MyEventHandler();

    class MyEvent
    {
        public event MyEventHandler OnSomeEvent;

        public void SomEvent()
        {
            if (OnSomeEvent != null)
            {
                OnSomeEvent();
            }
        }
    }

    class EventDemo
    {
        public static void Handler()
        {
            Console.WriteLine("Event occured!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyEvent me = new MyEvent();

            me.OnSomeEvent += EventDemo.Handler;

            me.SomEvent();

        }
    }
}
