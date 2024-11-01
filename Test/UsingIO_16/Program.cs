using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            decimal b,avg, sum=0;
            Console.WriteLine("Please enter the count(Whole Number) of numbers");
            n=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the each number of the "+n+" numbers below for average:");
            
            try
            {
                for (int i = 0; i < n; i++)
                {
                    b = decimal.Parse(Console.ReadLine());
                    sum += b;
                }

                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                avg = sum / n;
                Console.WriteLine("The average of the numbers is: " + avg);

                avg = sum = n = 0;
            }
        }
    }
}
