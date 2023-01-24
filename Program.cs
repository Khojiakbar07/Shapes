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

            /*
            switch (shapes)
            {
                case Circle circle:
                    Console.WriteLine($"{circle.area()}");
                    Console.WriteLine($"{circle.perimeter()}");
                    break;
                case Triangle tri:
                    Console.WriteLine($"{tri.area()}");
                    Console.WriteLine($"{tri.perimeter()}");
                    break;
                case Rectangle rec:
                    Console.WriteLine($"{rec.area()}");
                    Console.WriteLine($"{rec.perimeter()}");
                    break;
                default:
                    Console.WriteLine("<unknown shape>");
                    break;

            }

        }
       
    }
}
