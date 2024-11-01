using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter s = null;

            try
            {
                s = new StreamWriter(@"D:\Chandu4923.txt");

                Console.SetOut(s);

                Console.WriteLine("This is the start of log file:");

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("This is the end of log file");

            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(s != null)
                {
                    s.Close();
                }
            }
            
        }
    }

    class Demo
    {
    }
}
