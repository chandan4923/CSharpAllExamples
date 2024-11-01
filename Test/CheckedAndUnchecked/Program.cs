using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedAndUnchecked
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a, b;
            
            byte result;

            try
            {
                unchecked
                {
                    a = 5;
                    b = 125;
                    result = unchecked((byte)(a * b));
                    Console.WriteLine(result);

                    a = b = 127;
                    result = unchecked((byte)(a * b));
                    Console.WriteLine(result);
                }
                checked
                {
                    a = 2;
                    b = 7;
                    result = checked((byte)(a * b));
                    Console.WriteLine(result);

                    a = b = 127;
                    result = checked((byte)(a * b));
                    Console.WriteLine(result);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Message" + ex.Message);
                //Console.WriteLine("Stack Trace: "+ex.StackTrace);
                //Console.WriteLine("Data:"+ex.Data);
                //Console.WriteLine("Target SIte"+ex.TargetSite);
            }
}
    }
}
