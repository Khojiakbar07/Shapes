using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Triangle 
    {
        private double a;
        private double b;
        private double c;
        private bool access;
        

        public Triangle(String color, double a, double b, double c)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            if ((this.a + this.b > this.c) && (this.a + this.c > this.b) && (this.b + this.c > this.a))
            {
                this.access = true;
            }
            else
            {
                this.access = false;
            }
        }
        public void info(string color)
        {
            Console.WriteLine("***Shape is Triangle***");
            Console.WriteLine("Color: " + color);
            Console.WriteLine("a (side-1): " + this.a);
            Console.WriteLine("b (side-2): " + this.b);
            Console.WriteLine("c (side-3): " + this.c);
            Console.WriteLine("---------------------");
        }
        public double calculateArea(double area)
        {
            if (this.access)
            {
                double p;
                p = (this.a + this.b + this.c) / 2;
                area = Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
                Console.WriteLine("Area (Triangle): " + area);
                return area;
            }
            else
            {
                Console.WriteLine("Wrong sides for triangle to calculate area");
                return 0.0;
            }
        }
        public double calculatePerimeter(double perimeter)
        {
            if (this.access)
            {
             
                double p;
                p = this.a + this.b + this.c;
                Console.WriteLine("Perimeter (Triangle): " + perimeter);
                return 0.0;
            }
            else
            {
                Console.WriteLine("Wrong sides for triangle to calculate perimeter");
                return 0.0;
            }
        }
    }
}
    
