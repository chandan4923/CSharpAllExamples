using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events5
{
    delegate void EventhandlerD();

    class MyEvent
    {
        EventhandlerD[] xevents = new EventhandlerD[3] ;

        public event EventhandlerD OnSomeEvent
        {
            add
            {
                int i = 0;

                for (i = 0; i < 3; i++)
                {
                    if (xevents[i] == null)
                    {
                        xevents[i] = value;
                        break;
                    }
                }
                if (i == 3)
                {
                    Console.WriteLine("Event Handler list is full");
                }
            }
            remove
            {
                int i = 0;
                for ( i = 0; i < 3; i++)
                {
                    if (xevents[i] == value)
                    {
                        xevents[i] =null;
                    }
                }
                if (i == 3)
                {
                    Console.WriteLine("Event Hnadler list is empty");
                }
            }
        }

        public void SomeEvent()
        {
            int i = 0;
            for (i = 0; i < 3; i++)
            {
                xevents[i]();
            }
            
        }
    }

    class X
    {
        public static void XHandler()
        {
            Console.WriteLine("XHandler has been called!");
        }
    }
    class Y
    {
        public static void YHandler()
        {
            Console.WriteLine("YHandler has been called!");
        }
    }
    class W
    {
        public static void WHandler()
        {
            Console.WriteLine("WHandler has been called!");
        }
    }
    class Z
    {
        public static void ZHandler()
        {
            Console.WriteLine("ZHandler has been called!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyEvent myEvent = new MyEvent();

            myEvent.OnSomeEvent += X.XHandler;
            myEvent.OnSomeEvent += Y.YHandler;
            myEvent.OnSomeEvent += W.WHandler;
            myEvent.OnSomeEvent += Z.ZHandler;

            myEvent.SomeEvent();

        }
    }
}
