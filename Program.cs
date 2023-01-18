using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle("Red","Rectangle",5,5);
            rec.Draw();
            rec.perimeter();
            rec.area();

            Triangle tri = new Triangle("Blue","Triangle",3,4,5);
            tri.Draw();
            tri.perimeter();
            tri.area();
            
            Circle circle = new Circle("Red","Rectangle",5);
            circle.Draw();
            circle.perimeter();
            circle.area();
        }
    }
}

