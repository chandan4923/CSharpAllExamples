using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceContructorWithObjects
{

    abstract class TwoD
    {
        

        private double _width, _heigth;
        string _name;

        public string name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double width
        {
            get { return _width; }
            set { _width = value < 0 ? -value : value; }
        }
        public double height
        {
            get { return _heigth; }
            set { _heigth = value < 0 ? -value : value; }
        }
        public TwoD()
        {
            width = height = 0;
        }
        public TwoD(double w,double h)
        {
            width = w;
            height = h;
        }
        public TwoD(string n,double x)
        {
            width = height = x;
            name = n;
        }
        public TwoD(string n, double w,double h)
        {
            name = n;
            width = w;
            height = h;
        }

        public TwoD(TwoD ob)
        {
            width = ob.width;
            height = ob.height;
            name = ob.name;
        }
        public void ShowDim()
        {
            Console.WriteLine("Width and heigth are: " + width + "and " + height);
        }
        public virtual double Area()
        {
            Console.WriteLine("Area() must be overriden");
            return 0.0;
        }

}
    class Triangle : TwoD
    {
        public string style;
        public Triangle()
        {

        }
        public Triangle(string h)
        {
            style = null;
        }
        public Triangle(string s, double w, double h) : base(s,w, h)
        {
            style = s;
        }
        public Triangle(string s, double x) : base(s,x)
        {
            style = s;
        }
        public Triangle(Triangle ob):base(ob)
        {
            style = ob.style;
        }

        public sealed override double Area()
        {
            return width* height / 2;
    }

    public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + style);
        }
    }
    class X : Triangle
    {
        public override double Area()
        {

        }
    }
    class Rectangle : TwoD
    {
        public Rectangle(double w, double h):base("Rectangle",w,h)
        {

        }
        public Rectangle(double w):base("Rectangle",w)
        {

        }
        public override double Area()
        {
            return width * height;
        }
        public Rectangle(Rectangle ob):base(ob)
        {

        }
        public bool IsSquare()
        {
            if (width == height) return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Triangle T1 = new Triangle( "Isoceles", 4.0, 6.0);
            // Triangle T2 = new Triangle("Right", 8.0, 12.0);
            //Triangle T3 = new Triangle(T2);

            // T1.ShowDim();
            // T1.ShowStyle();

            // T2.ShowDim();
            // T2.ShowStyle();

            // T3.ShowDim();
            // T3.ShowStyle();

            TwoD[] Shapes = new TwoD[5];
            
                Shapes[0] = null;
           
           
                Shapes[1] = new Triangle("Isoceles", 4.0, 6.0);
            Shapes[2] = new Rectangle(77);
            Shapes[3] = new Rectangle(9, 6);
            Shapes[4] = new Triangle("Equilateral",7.0);


            for (int i = 0; i < Shapes.Length; i++)
            {
               try
            {
                Shapes[i].ShowDim();
                Console.WriteLine("Object is "+Shapes[i].name);
                Console.WriteLine("Area is "+Shapes[i].Area());

                }
                catch
                {
                    Console.WriteLine("Object cannot be null");
                }
            }
        }
    }
}
