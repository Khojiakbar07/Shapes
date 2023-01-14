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
        private bool access;
        public Rectangle(string Color, string typeShape, double a, double b) : base(Color, typeShape)
        {
            this.a = a;
            this.b = b;

        }
        

        public void Draw()
        {
            Console.WriteLine("Shape is Rectangle :");
        }

        public double perimeter()
        {
            if (this.access)
            {

                double p;
                p = (this.a + this.b) * 2;
                Console.WriteLine("Area (Rectangle): " + p);//5
                return 0.0;
            }
            else
            {
                Console.WriteLine("Wrong sides for rectangle to calculate perimeter");
                return 0.0;
            }
        }
        public double area()
        {
            if (this.access)
            {

                double Area;
                Area = (this.a * this.b);
                Console.WriteLine("Perimeter (Rectangle): " + Area);//25
                return 0.0;
            }
            else
            {
                Console.WriteLine("Wrong sides for rectangle to calculate area");
                return 0.0;
            }
        }
    }
}
