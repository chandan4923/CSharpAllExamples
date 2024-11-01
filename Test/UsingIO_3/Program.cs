using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UsingIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = null;
            int i;
            string s = @"D:\Share\Chandan.txt";
            args = s.Split();
            try
            {
                f = new FileStream(args[0], FileMode.Open);

                do
                {
                    i = f.ReadByte();
                    if (i != -1)
                    {
                        Console.Write((char)i);
                    }

                }
                while (i != -1);

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (f != null)
                {
                    f.Flush();
                }
            }
        }
    }
}
