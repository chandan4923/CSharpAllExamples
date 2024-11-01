using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload
{
    class CheckOverLoad
    {
        public void Over()
        {
            Console.WriteLine("No arguments are present");
        }
        public void Over(int a)
        {
            Console.WriteLine("Value of argument is: "+a);
        }
        public int Over(int a,int b)
        {
            Console.WriteLine("Arguemnets passed are of type integers and it has return type of integer");
            return a + b;
        }
        
        public double Over(double a,double b)
        {
            Console.WriteLine("Arguemnets passed are of type double and it has return type of double");
            return a + b;
        }
    }

    class TypEConversionMethodOverload
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            CheckOverLoad checkOverLoad = new CheckOverLoad();
            checkOverLoad.Over();
            checkOverLoad.Over(30);
            Console.WriteLine(checkOverLoad.Over(98, 763));
            Console.WriteLine(checkOverLoad.Over(8.45, 9.076));

        }
    }
}
