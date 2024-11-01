using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnObjects
{
    class Rect
    {
        int _width;
        int _height;

        public Rect(int width, int heigth)
        {
            _width = width;
            _height = heigth;
        }
        public int Area()
        {
            return _width * _height;
        }
        public void Show()
        {
            Console.WriteLine(_width+ " "+_height);
        }

        public Rect Enlarge(int factor)
        {
            return new Rect(_width * factor, _height * factor);
        }
    }
    class FindFactors
    {
        int[] Factors = new int[80];
       

        public int[] Findfact(int num, out int numfactors)
        {
            int j = 0;
            for (int i = 2; i < num/2+1; i++)
            {
                
                if (num%i==0)
                {
                    
                    Factors[j] = i;
                    j++;
                }
            }
            numfactors = j;
            return Factors;
        }

    }


    class MyClass
    {
        int i, j;
        public MyClass FactoryClass(int a, int b)
        {
            MyClass myClass = new MyClass();
            myClass.i = a;
            myClass.j = b;
            return myClass;
        }
        public void Show()
        {
            Console.WriteLine("Values of i and j are: "+i+" "+j);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Rect rect = new Rect(10, 20);

            //rect.Show();

            //Console.WriteLine("Area is: "  +rect.Area());

            //Rect rect1 = rect.Enlarge(10);
            //rect1.Show();
            //Console.WriteLine("Area is: " + rect1.Area());
            //int i, j;

            //MyClass myClassExternal = new MyClass();
            //for (i = 0, j = 10; i <= 10& j >= 0;j--,i++)
            //    {
            //   MyClass myClassIteration= myClassExternal.FactoryClass(j, i);
            //    myClassIteration.Show();
            //}
            FindFactors findFactors = new FindFactors();
            int lengthOfArray;
            int n = 1000;
            int[] j=findFactors.Findfact(n, out lengthOfArray);
            for(int i=0;i<lengthOfArray; i++)
                {
                Console.WriteLine("Factors of "+n+": "+j[i]);
            }
            Console.WriteLine("Length of the array is: "+lengthOfArray);
        }
    }
}
