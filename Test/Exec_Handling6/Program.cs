using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Handling6
{
    class ExceptA : Exception
    {
        public ExceptA(string message):base(message)
        {

        }
        public override string ToString()
        {
            return "CHANDAN IS A GOOD BOY";
        }
    }
    class ExceptB: ExceptA
    {
        public ExceptB(string message):base(message)
        {

        }
        public override string ToString()
        {
            return Message;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    switch (i)
                    {
                        case 0:
                            throw new ExceptA("Exception is from class A");
                        case 1:
                            throw new ExceptB("Exception is from class B");
                        default:
                            throw new Exception();
                    }
                }
                
                catch (ExceptB ex)
                {
                    Console.WriteLine(ex);
                }
                catch (ExceptA ex)
                {
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
