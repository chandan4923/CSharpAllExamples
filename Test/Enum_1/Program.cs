using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_1
{
    class Conveyor
    {
        public enum Input
        {
            Start,
            Stop,
            Forward,
            Reverse,
        }
        public void Action(Input com)
        {
            switch(com)
            {
                case Input.Start:
                    Console.WriteLine("Conveyor belt is starting");
                    break;

                case Input.Stop:
                    Console.WriteLine("Conveyor belt is stopping");
                    break;
                case Input.Forward:
                    Console.WriteLine("Conveyor belt is forwading");
                    break;

                case Input.Reverse:
                    Console.WriteLine("Conveyor belt is Reversing");
                    break;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Conveyor c = new Conveyor();

            c.Action(Conveyor.Input.Start);
            c.Action(Conveyor.Input.Stop);
            c.Action(Conveyor.Input.Forward);
            c.Action(Conveyor.Input.Reverse);
        }
    }
}
