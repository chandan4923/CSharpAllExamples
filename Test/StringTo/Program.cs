using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTo
{
    class MyClass
    {
        static int count=0;
        int ID;

        public MyClass()
        {
            ID=count;
            count++;
        }

        public override string ToString()
        {
            return $"The value of ID is #"+ID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass();
            MyClass ob2 = new MyClass();
            MyClass ob3 = new MyClass();

            Console.WriteLine(ob1);
            Console.WriteLine(ob2);
            Console.WriteLine(ob3);
        }
    }
}
