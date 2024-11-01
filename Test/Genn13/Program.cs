using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genn13
{

    struct XY<T>
    {
        T x;
        T y;

        public XY(T a, T b)
        {
            x = a;
            y = b;
        }

        public T X 
        {
            get 
            {
                return x;
            }
            set 
            {
                x = value;
            }
        }
        public T Y {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            XY<int> xy = new XY<int>(1, 2);
            XY<string> xy1 = new XY<string>("CHANDAN", "SADASIVUNI");

            Console.WriteLine(xy.X+" "+xy.Y);
            Console.WriteLine(xy1.X+" "+xy1.Y);
        }
    }
}
