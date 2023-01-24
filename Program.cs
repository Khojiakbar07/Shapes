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
            Circle circle = new Circle("Green", "Circle", 2);
            Console.WriteLine("Choose one of the given shapes: ");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Circle");
            String shapes = Console.ReadLine();
            if (shapes == "Rectangle")
            {
                rec.Draw();
                rec.perimeter();
                rec.area();
            }
            else if (shapes == "Triangle")
            {
                tri.Draw();
                tri.perimeter();
                tri.area();
            }
            else if (shapes == "Circle")
            {
                circle.Draw();
                circle.perimeter();
                circle.area();
            }
            else
            {
                Console.WriteLine($"{shapes}: is unknown shape");
            }

            Console.WriteLine("Choose one of the given shapes: ");
            Console.WriteLine("1. Rectangle Perimeter or Rectangle Area");
            Console.WriteLine("2. Triangle Perimeter or Triangle Area");
            Console.WriteLine("3. Circle Perimeter or Circle Area");

            switch (shapes)
            {
                case "Rectangle Perimeter":
                    Console.WriteLine($"{rec.perimeter()}");
                    break;
                case "Rectangle Area":
                    Console.WriteLine($"{rec.area()}");
                    break;
                case "Triangle Perimeter":
                    Console.WriteLine($"{tri.perimeter()}");
                    break;
                case "Triangle Area":
                    Console.WriteLine($"{tri.area()}");
                    break;
                case "Circle Perimeter":
                    Console.WriteLine($"{circle.perimeter()}");
                    break;
                case "Circle Area":
                    Console.WriteLine($"{rec.area()}");
                    break;
                default:
                    Console.WriteLine("Can not calculate perimeter and area");
                    break;

            }
            Console.ReadLine();
        }
       
    }
}
