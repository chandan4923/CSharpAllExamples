using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events6
{
    delegate void EventHandler(int i);

    class Event
    {
        public event EventHandler SomeEvent;

        public void OnSomeEvent(int n)
        {
            if (SomeEvent != null)
            {
                SomeEvent(n);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Event event1 = new Event();

            //event1.SomeEvent += (n) => Console.WriteLine("The value of is: "+n);

            event1.SomeEvent += delegate(int n)
            {
                Console.WriteLine("The value of n is: " + n);
            };

            event1.OnSomeEvent(10);
            event1.OnSomeEvent(30);
        }
    }
}
