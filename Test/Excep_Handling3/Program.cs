using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep_Handling3
{
    class UsingFInally
    {
        public static int GenerateException(int i)
        {
            int[] A = new int[3];
            int t;
            try
            {
                switch (i)
            {
                case 0:
                       return t = 10 / 10;
                        Console.WriteLine(t);
                    break;
                case 1:
                   return t = A[4];
                    break;
                case 2:
                    return 0;
            }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Matching element could not be found");
                return 80;
            }
            finally
            {
                Console.WriteLine("Leaving try block");
                Console.WriteLine();
               
                
            }
            return 20;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
                for (int i = 0; i < 3; i++)
                {
                Console.WriteLine(UsingFInally.GenerateException(i));
                
                }
            
        }
    }
}
