using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIndexer
{

    interface IA
    {
        void MethA();

        void MethB();
    }

    interface IB : IA
    {
        void MethC();
    }

    class A : IB
    {
        public void MethA()
        {
            Console.WriteLine("Implementation of A");
        }

        public void MethB()
        {
            Console.WriteLine("Implementation of B");
        }

        public void IB.MethC()
        {
            Console.WriteLine("Implementation of C");
        }
    }
    interface ISeries
    {
        int GetNext
        {
            get;
            set;
        }

        int this[int index]
        {
            get;
        }
    }

    class ByTwos : ISeries
    {

        int val;
        public ByTwos()
        {
            val = 0;
        }
        public int this[int index]
        {
            get
            {
                val = 0;
                for (int i = 0; i < index; i++)
                {
                    val += 2;
                    
                }
                return val;
            }
        }

        public int GetNext
        {
            get
            {
                val += 2;
                return val;
            }
            set
            {
                val = value;
            }
        }

        public void Reset()
        {
            val = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ByTwos bT = new ByTwos();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Value of next is "+bT.GetNext);
            //}

            //bT.GetNext = 21;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Value of next after resetting to 21 are " + bT.GetNext);
            //}


            //bT.Reset();

            //Console.WriteLine("Values after ressetting");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Value of next after resseting "+bT[i]);
            //}

            A a = new A();

            //a.MethA();
            //a.MethB();
            //a.MethC();
        }
    }
}
