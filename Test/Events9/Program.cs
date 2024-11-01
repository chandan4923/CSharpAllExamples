using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events9
{
    class KeyEventArgs : EventArgs
    {
        public char ch;
    }
    class Event
    {
        public event EventHandler<KeyEventArgs> KeyPress;

        public void OnKeyPress(char x)
        {
            KeyEventArgs keyEventArgs = new KeyEventArgs();

            if (KeyPress != null)
            {
                keyEventArgs.ch = x;
                KeyPress(this, keyEventArgs);
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Event @event = new Event();
            int count = 0;

            @event.KeyPress += (sender, e) =>
              {
                  Console.WriteLine("\r\nKey pressed is: " + e.ch);
              };

            @event.KeyPress += (sender, e) =>
              {
                  count++;
              };
            bool s = true;
            do
            {
                key = Console.ReadKey();
                if (key.KeyChar != '.')
                {
                    @event.OnKeyPress(key.KeyChar);
                }
                else
                {
                    s = false;
                }
            } while (s);
            Console.WriteLine("\r\n"+count+" time the keys have been pressed");

        }
    }
}
