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
            Console.WriteLine("Choose one of the given shapes: ");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Circle");
            String shapes = Console.ReadLine();
            
            switch (shapes)
            {
                case "Rectangle ":
                    rec.Draw();
                    break;
                case "Triangle ":
                    tri.Draw();
                    break;
                case "Circle ":
                    circle.Draw();
                    break;
                default:
                    Console.WriteLine($"{shapes}: is unknown shape");
                    break;
            }

            Console.WriteLine("Enter Shape name and perimeter ");

            shapes = Console.ReadLine();
            switch (shapes)
            {
                case "Rectangle perimeter":
                    rec.perimeter();
                    break;
                case "Triangle perimeter":
                    tri.perimeter();
                    break;
                case "Circle perimeter":
                    circle.perimeter();
                    break;

            }
            Console.WriteLine("Enter Shape name and Area ");
            shapes = Console.ReadLine();
            switch (shapes)
            {
                case "Rectangle area":
                    rec.area();
                    break;
                case "Triangle area":
                    tri.area();
                    break;
                case "Circle area":
                    circle.area();
                    break;
            }
            Console.ReadLine();
            /*
            shapes = Console.ReadLine();
            switch (shapes)
            {
                case "Rectangle perimeter":
                    rec.perimeter();
                    break;
                case "Rectangle area":
                    rec.area();
                    break;
                case "Triangle perimeter":
                    tri.perimeter();
                    break;
                case "Triangle area":
                    tri.area();
                    break;
                case "Circle perimeter":
                    tri.perimeter();
                    break;
                case "Circle area":
                    circle.area();
                    break;
            }
            */
        }
    }
}
