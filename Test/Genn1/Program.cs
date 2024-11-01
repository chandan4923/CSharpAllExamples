using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn1
{
    class NonGen
    {
        object ob;
        public NonGen(object o)
        {
            ob = o;
        }
        public object GetObj()
        {
            return ob;
        }

        public void GetType1()
        {
            Console.WriteLine("The type of object is:"+ob.GetType());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NonGen ing = new NonGen(115);

            Console.WriteLine(ing.GetObj());

            ing.GetType1();


            NonGen sng = new NonGen("Non Generic Test!");

            string s = sng.GetObj();

            Console.WriteLine(sng.GetObj());

            sng.GetType1();
        }
    }
}
