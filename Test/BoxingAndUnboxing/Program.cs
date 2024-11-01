using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x=10;
            object ob;
            ob = x;


            int y = (int)ob;
            //Console.WriteLine(y);
            int K = 10;
            
            //Console.WriteLine("Value of K is: "+Sqr(K));

            object[] arrOb = new object[10];

            for (int i = 0; i < 3; i++)
            {
                arrOb[i] = i;
            }
            for (int i = 3; i < 6; i++)
            {
                arrOb[i] = (double)i / 2;
            }

            arrOb[6] = "Hello";
            arrOb[7] = true;
            arrOb[8] = 'X';
            arrOb[9] = "END!";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("arrOb["+i+"]="+arrOb[i]);
            }
            
        }
        public static int Sqr(object o)
        {

            return (int)o * (int)o;
        }
    }
}
