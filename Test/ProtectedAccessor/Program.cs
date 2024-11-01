using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedAccessor
{
    class B
    {
        protected int i, j;
        protected int l;

        public void Set(int a , int b)
        {
            i = a;
            j = b;
        }
        public void Show()
        {
            Console.WriteLine(i+" "+j);
        }
    }

    class D : B
    {
        int k;
        public void SetK()
        {
            k = i * j;
        }

        public void ShowK()
        {
            Console.WriteLine(k);
        }

    }
    class C : D
    {
        public void Own()
        {
            Console.WriteLine(l);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.Set(20, 30);
            d.Show();

            d.SetK();
            d.ShowK();
        }
    }
}
