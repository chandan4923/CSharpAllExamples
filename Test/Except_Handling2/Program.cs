using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except_Handling2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Before Exception");
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception Caught");
            }
            finally
            {
                Console.WriteLine("After try/catch");
            }
        }
    }
}
