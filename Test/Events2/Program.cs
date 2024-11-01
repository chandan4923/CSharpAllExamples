using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    delegate void EventHandler();

    class MyEvent
    {
        public event EventHandler OnSomeEvent;

        public void SomeEvent()
        {
            if (OnSomeEvent != null)
                OnSomeEvent();
        }
    }
    class X
    {
        public void XHandler()
        {
            Console.WriteLine("X object event has been called");
        }
    }
    class Y
    {
        public void YHandler()
        {
            Console.WriteLine("Y object event has been called");
        }
    }
    class Z
    {
        public void ZHandler()
        {
            Console.WriteLine("Z object event has been called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyEvent myevent = new MyEvent();

            X x = new X();
            Y y = new Y();
            Z z = new Z();

            myevent.OnSomeEvent += x.XHandler;
            myevent.OnSomeEvent += y.YHandler;
            myevent.OnSomeEvent += z.ZHandler;

            myevent.SomeEvent();

        }
    }
}
