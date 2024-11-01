using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassFactory
{

    class MyClass
    {
        int a, b;
        public static MyClass Factory(int i , int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;

            return t;
        }
        public void Show()
        {
            Console.WriteLine(" a and b: "+a+","+b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int i, j;

            for (i = 0, j = 10; i <= 10& j >= 0;i++,j--)
            {
                MyClass ob = MyClass.Factory(i, j);
                ob.Show();
            }
        }
    }
}
