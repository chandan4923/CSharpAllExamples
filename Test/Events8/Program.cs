using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events8
{
    class MyEvent
    {
        public event EventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
            {
                SomeEvent(this, EventArgs.Empty);
            }
        }
    }
    class Program
    {
        static void Handler(object sender, EventArgs e)
        {
            Console.WriteLine("Event occured");
            Console.WriteLine("Source is: "+sender);
        }
        static void Main(string[] args)
        {
            MyEvent myEvent = new MyEvent();

            myEvent.SomeEvent += Handler;

            myEvent.OnSomeEvent();
        }
    }
}
