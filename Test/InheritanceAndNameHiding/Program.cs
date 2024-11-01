using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndNameHiding
{
    class A
    {
        public int i = 44;

        public void Show()
        {
            Console.WriteLine("Value of i in base class: " + i);
        }
    }
    class B : A
    {
        new int i;
        public B(int a, int b)
        {
            base.i = a;
            i = b;
        }
        new public void Show()
        {
            base.Show();
            Console.WriteLine("Value of i in derived class: "+this.i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B(67,20);
            b.Show();
        }
    }
}
