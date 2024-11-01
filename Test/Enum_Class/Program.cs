using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Class
{
    enum Apple:byte
    {
        Jonathan, GoldenDel,RedDel, Winesap=10, Cortlant, McIntosh
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] color = { "Red", "Yellow", "Red", "Red", "Red", "Reddish Green" };

            Apple i;

            for(i=Apple.Jonathan; i<=Apple.McIntosh; i++)
            {
                Console.WriteLine(i +" has value of "+(int)i);
            }

            //for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
            //{
            //    Console.WriteLine(i + " has color as " + color[(int)i]);
            //}

        }
    }
}
