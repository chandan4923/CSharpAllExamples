using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailSafe2DIndexer
{

    class FailSafeTwoD
    {
        int[,] a;
        int row, col;

        public int length;
        public bool errFlag;

        public FailSafeTwoD(int row, int col)
        {
            this.row = row;
            this.col = col;
            a = new int[row, col];
            length = this.row * this.col;
        }

        public int this[int i1,int i2]
        {
            get 
            {
                if (OK(i1, i2))
                {
                    
                    errFlag = false;
                    return a[i1,i2];
                }
                else
                {
                    errFlag = true;
                    return 0;
                }
            }
            set
            {
                if (OK(i1, i2))
                {
                    a[i1, i2] = value;
                    errFlag = false;
                }
                else
                {
                    errFlag = true;
                }
            }
        }

        public bool OK(int i, int j)
        {
            if ((i >= 0 & i < this.row) & (j >= 0 & j < this.col))return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FailSafeTwoD F = new FailSafeTwoD(3, 5);
            int x;

            Console.WriteLine("Value of F is: ");
            for (int i =0; i< 6; i++)
            {
                F[i, i] = i * 10;

                
                Console.Write(F[i, i]+" ");
            }
            Console.WriteLine("\n");

            for(int i = 0;i<6; i++)
            {
                x = F[i, i];

                if(!F.errFlag)
                Console.WriteLine("Value of X is: "+x);

                else Console.WriteLine("Value of X("+x+") is out of bound");
            }

        }
    }
}
