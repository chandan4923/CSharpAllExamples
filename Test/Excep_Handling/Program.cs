using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep_Handling
{
    class ExcTest
    {
        
        public static void Execute()
        {
            int[] A = new int[4];
            for (int i = 0; i < 10; i++)
            {
                A[i] = i;
                Console.WriteLine("Num[" + i + "]: " + i);
            }

            Console.WriteLine("This won't be displayed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                ExcTest.Execute(); 
            }
            catch(IndexOutOfRangeException ex) 
            {
                //Console.WriteLine("Index out of Bound Error");
                Console.WriteLine("Standard Message is: ");
                Console.WriteLine(ex);
                Console.WriteLine("Stack Trace: "+ex.StackTrace);
                Console.WriteLine("Message: "+ex.Message);
                Console.WriteLine("TargetSite: "+ex.TargetSite);

            }
            Console.WriteLine("After catch block");

        }
    }
}
