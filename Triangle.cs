using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Triangle : Shape, Drawable
    {
        private double a;
        private double b;
        private double c;
        private bool access;
        public Triangle(string Color, string typeShape) : base(Color, typeShape)
        {
 
        }
        public void Draw()
        {
            Console.WriteLine("--------------------------");
        }

        public double perimeter()
        {
            if (this.access)
            {

                double p;
                p = this.a + this.b + this.c;
                Console.WriteLine("Perimeter (Triangle): " + p);
                return 0.0;
            }
            else
            {
                Console.WriteLine("Wrong sides for triangle to calculate perimeter");
                return 0.0;
            }
        }
        public double area()
        {
            if (this.access)
            {

                double Area;
                Area = (this.a + this.b) * 2;
                Console.WriteLine("Area (Triangle): " + Area);
                return 0.0;
            }
            else
            {
                Console.WriteLine("Wrong sides for triangle to calculate area");
                return 0.0;
            }
        }
    }
}

    
