using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UsingIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            FileStream F;
            string s =@"D:\Share\Chandan.txt";

            args = s.Split();
            

            if (args.Length != 1)
            {
                Console.WriteLine("Usage: ShowFIle FIle");
                return;
            }

            try
            {
                F  = new FileStream(args[0], FileMode.Open);
            }
            catch(IOException ex)
            {
                Console.WriteLine("File cannot be opened");
                Console.WriteLine(ex.Message);
                return;
            }

            try
            {
                do
                {
                    i = F.ReadByte();

                    if (i != -1)
                    {
                        Console.Write((char)i);
                    }
                }
                while (i != -1);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                F.Dispose();
            }

        }
    }
}
