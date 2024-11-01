using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProperties
{
    interface ISeries
    {
        int Next { get; set; }
    }

    class ByTwos : ISeries
    {
        int val;
        public int Next
        {
            get { val += 2; return val; }
            set { val = value; }
        } 
    }
        class Program
        {
            static void Main(string[] args)
            {
            ByTwos BT = new ByTwos();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Value of next generated value is: "+BT.Next);
            }

            }
        }
    }

