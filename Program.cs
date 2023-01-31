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
                /*Rectangle class*/
                case "Rectangle" :
                    rec.Draw();
                    Console.WriteLine("1.Perimeter");
                    Console.WriteLine("2.Area");
                    Console.WriteLine("-------------------");
                    shapes = Console.ReadLine();
                    if (shapes == "1")
                    {
                        rec.perimeter();
                    }
                    else if (shapes == "2")
                    {
                        rec.area();
                    }
                    else
                    {
                        shapes = Console.ReadLine();
                    }
                    Console.WriteLine("");
                    Console.WriteLine("1.Perimeter");
                    Console.WriteLine("2.Area");
                    Console.WriteLine("-------------------");
                    shapes = Console.ReadLine();
                    if (shapes == "1")
                    {
                        rec.perimeter();
                    }
                    else if (shapes == "2")
                    {
                        rec.area();
                    }
                    break;
                /*Triangle class*/
                case "Triangle":
                    tri.Draw();
                    Console.WriteLine("1.Perimeter");
                    Console.WriteLine("2.Area");
                    Console.WriteLine("-------------------");
                    shapes = Console.ReadLine();
                    if (shapes == "1")
                    {
                        tri.perimeter();
                    }
                    else if (shapes == "2")
                    {
                        tri.area();
                    }
                    else 
                    {
                        shapes = Console.ReadLine();
                    }
                    Console.WriteLine("");
                    Console.WriteLine("1.Perimeter");
                    Console.WriteLine("2.Area");
                    Console.WriteLine("-------------------");
                    shapes = Console.ReadLine();
                    if (shapes == "1")
                    {
                        tri.perimeter();
                    }
                    else if (shapes == "2")
                    {
                        tri.area();
                    }
                    break;
                    /*Circle class*/
                case "Circle":
                    circle.Draw();
                    Console.WriteLine("1.Perimeter");
                    Console.WriteLine("2.Area");
                    Console.WriteLine("-------------------");
                    shapes = Console.ReadLine();
                    if (shapes == "1")
                    {
                        circle.perimeter();
                    }
                    else if (shapes == "2")
                    {
                        circle.area();
                    }
                    else
                    {
                        shapes = Console.ReadLine();
                    }
                    Console.WriteLine("");
                    Console.WriteLine("1.Perimeter");
                    Console.WriteLine("2.Area");
                    Console.WriteLine("-------------------");
                    shapes = Console.ReadLine();
                    if (shapes == "1")
                    {
                        circle.perimeter();
                    }
                    else if (shapes == "2")
                    {
                        circle.area();
                    }
                    break;
                default:
                    Console.WriteLine($"{shapes}: is unknown shape");
                    break;

            }
            Console.Read();
        }
    }
}
