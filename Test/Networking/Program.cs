using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.mheducation.com/");
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            Stream istrm = resp.GetResponseStream();

            for (int i = 0; ; i++)
            {
                ch = istrm.ReadByte();

                if (ch == -1)
                {
                    break;
                }

                Console.Write((char)ch);

                if (i % 400 == 0)
                {
                    Console.Write("\n Press Enter");
                    Console.ReadLine();
                }
            }

            resp.Close();

            

        }
    }
}
