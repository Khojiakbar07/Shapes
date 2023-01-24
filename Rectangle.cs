using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle : Shape , Drawable
    {
        private double a;
        private double b;
        public Rectangle(string Color, string typeShape, double a, double b) : base(Color, typeShape)
        {
            this.a = a;
            this.b = b;

        }

        public void Draw()
        {
            Console.WriteLine("-------------You choose Rectangle-------------");
        }

        public double perimeter()
        {
                double p;
                p = (this.a + this.b) * 2;//5
                Console.WriteLine("Area (Rectangle): " + p);
                return 0.0;
        }
        public double area()
        {
                double Area;
                Area = (this.a * this.b); //25
                Console.WriteLine("Perimeter (Rectangle): " + Area);
                return 0.0;
        }
    }
}
