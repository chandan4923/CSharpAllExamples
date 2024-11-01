using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UsingIO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fin = null;
            string str;
            //try
            //{
            //    fin = new FileStream("G1.txt", FileMode.Create);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("Error while creating text file: "+ex.Message);
            //}
            StreamWriter s = new StreamWriter("G1.txt",true);

            try
            {
                do
                {
                    Console.WriteLine("Enter text here(Write 'STOP' to quit): ");
                    str = Console.ReadLine();
                    if (str != "STOP")
                    {
                        str = str + "\r\n";
                        s.Write(str);
                    }

                } while (str != "STOP");
                }
            catch (IOException e)
            {
                Console.WriteLine("Error occured while writing the string to file is: "+e.Message);
            }
            finally
            {
                s.Close();
            }
        }
    }
}
