using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struc_Class2
{

    struct PacketHeader
    {
        public uint packnumber;

        public uint packLen;
    }

    class Transaction
    {
        static uint transactionNum = 0;

        PacketHeader ph;

        string accountNumber;
        double purchaseAmount;

        public Transaction(string a, double p)
        {
            ph.packnumber = transactionNum++;
            accountNumber = a;
            purchaseAmount = p;

            ph.packLen = 512;
        }

        public void SendTransaction()
        {
            Console.WriteLine("Packet #:"+ph.packnumber+" Length: "+ph.packLen+" \n AccountNumber: "+accountNumber+" Cost: "+purchaseAmount);
        }
    }

    class Demo
    {
        public Transaction Call()
        {
            Transaction Y = new Transaction("Chandan", 857);
            return Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Transaction T4 = d.Call();

            T4.SendTransaction();


            Transaction T1 = new Transaction("12345", -100.12);
            Transaction T2 = new Transaction("AB-123", 333.54);
            Transaction T3 = new Transaction("8457-09", 9800);

            T1.SendTransaction();
            T2.SendTransaction();
            T3.SendTransaction();
            

            

        }
    }
}
