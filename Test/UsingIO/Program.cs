using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //char ch;
            //string str;

            //Console.Write("Press a key followed by Enter: ");

            //for (int i = 0; i < 4; i++)
            //{

            //    str = Console.In.ReadLine();
            //Console.WriteLine("Your key is: " + str);


            //}

            //ConsoleKeyInfo keypress;
            //Console.WriteLine("Enter Keystrokes. Enter Q to stop");


            //do
            //{
            //    keypress = Console.ReadKey();
            //    Console.WriteLine("Your key is: "+keypress.KeyChar);
            //    if ((ConsoleModifiers.Alt & keypress.Modifiers) != 0)
            //    {
            //        Console.WriteLine("Alt is pressed!");
            //    }
            //    if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0)
            //    {
            //        Console.WriteLine("Shift is pressed!");
            //    }
            //    if ((ConsoleModifiers.Control & keypress.Modifiers) != 0)
            //    {
            //        Console.WriteLine("Control is pressed!");
            //    }


            //}
            //while (keypress.KeyChar != 'Q');

            int a = 10, b = 0;

            int result;

            Console.Out.WriteLine("This will generate an exception");

            try
            {
                result = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.Out.WriteLine(ex.Message);
                //Console.Error.WriteLine(ex.Message);
            }

        }
    }
}
