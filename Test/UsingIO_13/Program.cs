using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIO_13
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter swr = null;
            StringReader srr = null;

            try
            {
                swr = new StringWriter();

                for (int i = 0; i < 10; i++)
                {
                    swr.WriteLine("The value of i is:" + i);
                }

                srr = new StringReader(swr.ToString());

                string s = srr.ReadLine();
                while (s != null)
                {
                    s = srr.ReadLine();
                    Console.WriteLine(s);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                if(swr!= null)
                {
                    swr.Close();
                }
                if (srr != null)
                {
                    srr.Close();
                }
            }
        }
    }
}
