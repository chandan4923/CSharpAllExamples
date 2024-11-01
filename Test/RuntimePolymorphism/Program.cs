using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolymorphism
{
    class Base
        {
        public virtual void Who()
        {
            Console.WriteLine("Who() in Base Class");
        }
        }
    class Derived1 : Base
    {
        public override void Who()
        {
            Console.WriteLine("Who() in Derived1 Class");
        }
    }
    class Derived2 : Derived1
    {
        //override public void  Who()
        //{
        //    Console.WriteLine("Who() in Derived2 Class");
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base B = new Base();
            Derived1 D1 = new Derived1();
            Derived2 D2 = new Derived2();

            Base objB;

            objB = B;
            objB.Who();

            objB = D1;
            objB.Who();

            objB = D2;
            objB.Who();
        }
    }
}
