using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execpt_Handling1
{
    class Rethrow
    {
        public static void GenExcep() { 
        int[] Num = { 4, 8, 16, 32, 64, 128, 256, 512 };
        int[] Denom = { 2, 0, 4, 4, 0, 8 };

            for (int i = 0; i<Num.Length; i++)
                {
                    try
                    {
                        Console.WriteLine(Num[i] + "/" + Denom[i] + "=" + Num[i] / Denom[i]);
                    }

                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("A number cannot be divided by zero");
                    }
                    //catch
                    //{
                    //    Console.WriteLine("Some exception occured..");
                    //}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("No Matching Element found with the index");
                    throw;
}

                }
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
                Rethrow.GenExcep();
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Fatal Error------Program will be terminated");
            //}
        }
    }
}
