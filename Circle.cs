using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : Shape , Drawable
    {
        private double radius;
        public Circle(string Color, string typeShape, double radius) : base(Color, typeShape)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("-------------You choose Circle-------------");
        }

        public double perimeter()
        {
            double p;
            p = 2 * Math.PI * this.radius;
            Console.WriteLine("Perimeter (Circle): " + p);
            return 0.0;
        }
        public double area()
        {
            double Area;
            Area =Convert.ToInt32(Math.PI * (this.radius) * (this.radius));
            Console.WriteLine("Area (Circle): " + Area);
            return 0.0;

        }
    }
}
