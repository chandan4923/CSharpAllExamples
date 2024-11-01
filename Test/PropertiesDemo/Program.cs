using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class SimpProp
    {
        int prop;

        public SimpProp()
        {
            prop = 0;
        }

        public int MyProp
        {
            get
            {
                return prop;
            }
            set
            {
                if (value >= 0)
                    prop = value;
                else { }
                   
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpProp S = new SimpProp();

            S.MyProp = 100;

            Console.WriteLine("The Value of prop is: "+S.MyProp);

            S.MyProp = -10;

            Console.WriteLine("The value of prop is: "+S.MyProp);

        }
    }
}
