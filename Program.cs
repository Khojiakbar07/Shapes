using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle("Red", "Rectangle", 5, 5);
            Triangle tri = new Triangle("Blue", "Triangle", 3, 4, 5);
            Circle circle = new Circle("Green", "Circle", 3);
        }
    }
}
