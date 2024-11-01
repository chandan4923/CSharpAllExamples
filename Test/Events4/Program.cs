using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events4
{
    delegate void EventHandler();
    class EventX
    {
        public event EventHandler OnSOmeEvent;

        public void SomeEvent()
        {
            if (OnSOmeEvent != null)
            {
                OnSOmeEvent();
            }
        }
    }

    class X
    {

        public static void XHandler()
        {
            Console.WriteLine("Static Event has occured!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventX eventx = new EventX();

            eventx.OnSOmeEvent += X.XHandler;

            eventx.SomeEvent();


        }
    }
}
