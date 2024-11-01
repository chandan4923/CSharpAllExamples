using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencesToMethods
{
    class MyClass
    {
        int alpha, beta;
        public MyClass(int i, int j)
        {
            alpha = i;
            beta = j;
        }
        public bool SameAs(MyClass ob)
        {
            if ((ob.alpha == alpha) & (ob.beta == beta))
                return true;
            else return false;
        }
        public void Copy(MyClass ob)
        {
            alpha = ob.alpha;
            beta = ob.beta;
        }
        public void Show()
        {
            Console.WriteLine("alphha: {0}, beta: {1}",alpha,beta);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(4,5);
            MyClass ob2 = new MyClass(6,7);

            Console.Write("ob1: ");
            ob1.Show();
            
            Console.Write("ob2: ");
            ob2.Show();

            if(ob1.SameAs(ob2))
                Console.WriteLine("Values in both ob1 and ob2 are same");
            else
                Console.WriteLine("Values in both ob1 and ob2 are not same");

            Console.WriteLine();

            ob2.Copy(ob1);
            Console.Write("New values of ob2 are: ");
            ob2.Show();

            if (ob1.SameAs(ob2))
                Console.WriteLine("Values in both ob1 and ob2 are same");
            else
                Console.WriteLine("Values in both ob1 and ob2 are not same");

            Console.WriteLine();

        }
    }
}
