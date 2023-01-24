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
        public Triangle(string Color, string typeShape,double a,double b,double c) : base(Color, typeShape)
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
        public void Draw()
        {
            Console.WriteLine("-------------You choose Triangle-------------");
        }
        public double perimeter()
        {
                double p;
                p = this.a + this.b + this.c;
                Console.WriteLine("Perimeter (Triangle): " + p);//12
                return 0.0;
        }
        public double area()
        {
                double p;
                double Area;
                p = (this.a + this.b + this.c) / 2;
                Area = Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
                Console.WriteLine("Area (Triangle): " + Area);//6
                return 0.0;
        }
    }
}


    
