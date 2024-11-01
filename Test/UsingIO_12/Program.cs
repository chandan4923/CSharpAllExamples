using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO_12
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] storage = new byte[255];
            MemoryStream ms = new MemoryStream(storage);

            StreamWriter sw = new StreamWriter(ms);
            StreamReader sr = new StreamReader(ms);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    
                    sw.WriteLine("byte[" + i + "]:" + i);
                }
                sw.WriteLine(".");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Flush();
            }

            try
            {
                foreach (char item in storage)
                {
                    if (item == '.')
                    {
                        break;
                    }
                    //else if(item==' ')
                    //{
                    //    Console.Write("\r\n");
                    //}
                    //else
                    //{
                        Console.Write(item);
                    //}
                }

                ms.Seek(0, SeekOrigin.Begin);

                string s = sr.ReadLine();
                while (s != null)
                {
                    s = sr.ReadLine();
                    if (s[0] == '.')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }

            finally
            {
                sw.Close();
                sr.Close();
                
            }
        }
    }
}
