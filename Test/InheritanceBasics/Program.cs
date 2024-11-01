using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    class TwoD
    {

        private double height, width;

        public double _height
        {
            get { return height; }
            set { height = value<0? -value:value; }
        }

        public double _width
        {
            get { return width; }
            set { width = value<0?-value:value; }
        }


        public void ShowDim()
        {
            Console.WriteLine("Width and heigth are: "+width+"and "+height);
        }
    }

    class Triangle:TwoD
    {
        public string style;

        public Triangle(double i, double j, string w)
        {
            _height = i;
            _width = j;
            style = w;
        }

        public double Area()
        {
            return _width * _height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle is "+style);
        }
    }

    class Rectangle:TwoD
    {
        public bool IsSquare()
        {
            if (_width == _height)
            {
                return true;
            }
            else return false;
        }

        public double Area()
        {
            return _width * _height;
        }
    }
    class Shapes
    {
        static void Main(string[] args)
        {
            Triangle T1 = new Triangle(4.0,6.0, "Isoceles");
            Triangle T2 = new Triangle(8.0,12.0,"Right");

            //T1._width = 4.0;
            //T1._height = 6.0;
            //T1.style = "Iscoceles";

            //T2._width = 8.0;
            //T2._height = 12.0;
            //T2.style = "Right";

            T1.ShowDim();
            T1.ShowStyle();
            Console.WriteLine("Area of triangle is "+T1.Area());


            T2.ShowDim();
            T2.ShowStyle();
            Console.WriteLine("Area of triangle is " + T2.Area());
        }
    }
}
