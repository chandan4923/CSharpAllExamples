using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UsingIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = null;
            //int i;
            string s = @"D:\Cupid4.txt";

            try
            {
                F = new FileStream(s, FileMode.CreateNew);

                for(char c ='A'; c < 'U'; c++)
                {
                    F.WriteByte((byte)c);
                }
                F.Close();

                F = new FileStream(s, FileMode.OpenOrCreate);

                char[] q = new char[] { 'm', 'y', ' ','i','s',' ','C','h','a','n','d','a','n'};
                byte[] b = new byte[] { };
                byte k;
                foreach(var i in q)
                {
                    k = (byte)i;
                   b= BitConverter.GetBytes(Convert.ToInt16(k));
                }

                F.Write(b,0,b.Length);
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex);
            }
            finally
            {
                if(F!=null)
                F.Close();
            }
        }
    }
}
