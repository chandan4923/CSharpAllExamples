using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitialiser
{
    class MyClass
    {
        public int x;
        public string str;
        public MyClass(int y, string s)
        {
            x = y;
            str = s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int j=0;
            string q="";
            MyClass myClass = new MyClass(j, q) { x = 100, str = "Chandan Sadasivuni" };
            Console.WriteLine(myClass.x+" "+myClass.str);
        }
    }
}
