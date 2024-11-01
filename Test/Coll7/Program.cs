using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll7
{
    class Program
    {
        public static void ShowBits(string rem,BitArray bits)
        {
            Console.WriteLine(rem);
            for (int i = 0; i < bits.Count; i++)
            {
                Console.Write("{0,-6}",bits[i]);
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            BitArray ba = new BitArray(8);
            byte[] b = { 67 };
            BitArray ba2 = new BitArray(b);

            ShowBits("Original Contents of ba:", ba);

            ba = ba.Not();
            ShowBits("Contents of ba after not:", ba);
            ShowBits("Contents of ba2:", ba2);

            BitArray ba3 = ba.Xor(ba2);


        }
    }
}
