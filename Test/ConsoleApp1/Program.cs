using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UsingIO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = @"D:\Cupid3.txt";
            string x = @"D:\Chandan.txt";
            args = new string[]{
                v,x
                
        };

            FileStream fin = null;
            FileStream fout = null;
            int i;

            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Copy File from to");
                return;
            }
            try
            {
                fin = new FileStream(args[0], FileMode.Open);
                fout = new FileStream(args[1], FileMode.Create);
                do
                {
                    i = fin.ReadByte();
                    if (i != -1)
                        fout.WriteByte((byte)i);

                } while (i != -1);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                fin.Close();
                fout.Close();
            }
        }
    }
}
