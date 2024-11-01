using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingBaseClassConstructor
{
    class TwoD
    {
        double _width, _height;

        public double width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value < 0 ? -value : value;
            }
        }
        public double height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value < 0 ? -value : value;
            }
        }
        public TwoD()
        {
            width = height = 0;
        }
        public TwoD(double w, double h)
        {
            width = w;
            height = h;
        }
        public TwoD(double x)
        {
            width = height = x;  
        }

        public void ShowDim()
        {
            Console.WriteLine("Width and heigth are: " + width + "and " + height);
        }
    }
    class Triangle : TwoD
    {
        public string style;
        public Triangle(string h)
        {
            style = null;
        }
        public Triangle(string s, double w, double h) : base(w, h)
        {
            style = s;
        }
        public Triangle(string s, double x) : base(x)
        {
            style = s;
        }

        public double Area()
        {
            return width * height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + style);
        }
    }
    class ColorTriangle : Triangle
    {
        string color;

        

        public ColorTriangle(string c, string s, double w, double h):base(s)
        {
            color = c;
        }
        public void ShowColor()
        {
            Console.WriteLine("Color of the triangle: "+color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ColorTriangle T1 = new ColorTriangle("Blue","Isoceles",4.0, 6.0 );
            ColorTriangle T2 = new ColorTriangle("Red","Right",8.0, 12.0);
            ColorTriangle T3 = new ColorTriangle();

            //T1._width = 4.0;
            //T1._height = 6.0;
            //T1.style = "Iscoceles";

            //T2._width = 8.0;
            //T2._height = 12.0;
            //T2.style = "Right";

            T1.ShowDim();
            T1.ShowStyle();
            Console.WriteLine("Area of triangle is " + T1.Area());
            T1.ShowColor();

            T2.ShowDim();
            T2.ShowStyle();
            Console.WriteLine("Area of triangle is " + T2.Area());
            T2.ShowColor();

            T3.ShowStyle();
        }
    }
}
