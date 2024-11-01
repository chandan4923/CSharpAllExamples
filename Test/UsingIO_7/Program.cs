using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO_7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = null;

            try
            {
                f = new FileStream(@"D:\Cupid3.txt", FileMode.Open);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            StreamReader SR = new StreamReader(f);
            try
            {

                //int i;
                //do
                //{
                //i = SR.Read();
                //if(i!=-1)
                //while (true)
                //{
                //    string s=SR.ReadLine();
                //    if(s!=null)
                //        Console.WriteLine(s);
                //    else
                //    {
                //        break;
                //    }
                //}
                while (!SR.EndOfStream)
                {
                    Console.Write(SR.ReadLine()+"\r\n");
                }
                
                //} while (i != -1);
                }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                SR.Close();
            }
        }
    }
}
