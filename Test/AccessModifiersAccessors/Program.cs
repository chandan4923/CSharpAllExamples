using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersAccessors
{
    class Property
    {
        int prop;


        public Property()
        {
            prop = 200;
        }
        public int MYProp
        {
            get
            {
                return prop;
            }

            private set
            {
                prop = value;
            }
        }

        public void IncrProp()
        {
             MYProp += 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Property P = new Property();

            //P.MYProp = 100;

            P.IncrProp();

            Console.WriteLine("Value of prop is: "+P.MYProp);

        }
    }
}
