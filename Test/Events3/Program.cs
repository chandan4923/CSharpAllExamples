using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events3
{
    delegate void MyHandler();

    class MyEvent
    {
        public event MyHandler OnSomeEvent;

        public void SomeEvent()
        {
            if (OnSomeEvent != null)
                OnSomeEvent();
        }
    }

    class X
    {
        int id;
        public X(int i)
        {
            id = i;
        }

        public void XHandler()
        {
            Console.WriteLine("Value of id is "+id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyEvent myEvent = new MyEvent();
            X x1 = new X(1);
            X x2 = new X(2);
            X x3 = new X(3);
            X x4 = new X(4);

            myEvent.OnSomeEvent += x1.XHandler;
            myEvent.OnSomeEvent += x2.XHandler;
            myEvent.OnSomeEvent += x3.XHandler;
            myEvent.OnSomeEvent += x4.XHandler;

            myEvent.SomeEvent();
        }
    }
}
