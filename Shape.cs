using Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Shape
    {
        private String color;
        private double area;
        private double perimeter;
        public Shape(String color) { this.color = color; }
        protected void info()
        {
            Console.WriteLine("Unknown shape");
            Console.WriteLine("Area: " + this.area);
            Console.WriteLine("Perimeter: " + this.perimeter);
            Console.WriteLine("--------------------------");
        }
        protected double calculateArea()
        {
            Console.WriteLine("Unknown shape,can not calculate area...");
            return 0.0;
        }
        protected double calculatePerimeter()
        {
            Console.WriteLine("Unknown shape,can not calculate perimeter...");
            return 0.0;
        }
    }
}
