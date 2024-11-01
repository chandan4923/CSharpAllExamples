using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struc_Class_1
{
    //struct MyStruct
    //{
    //    public int x;
    //}

    class MyStruct
    {
        public int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct A = new MyStruct();
            MyStruct B = new MyStruct();

            A.x = 10;
            B.x = 20;

            Console.WriteLine(A.x+" "+B.x);

            A = B;

            B.x = 33;

            Console.WriteLine(A.x + " " + B.x);
        }
    }
}
