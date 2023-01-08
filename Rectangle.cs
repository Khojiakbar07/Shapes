using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shape
{
    internal class Rectangle
    {
        private String color;
        private String typeShape;
        private double perimeter;
        private double area;

        public Rectangle(String Color, String TypeShape, double Perimeter, double Area)
        {
            this.color = Color;
            this.typeShape = TypeShape;
            this.perimeter = Perimeter;
            this.area = Area;
        }
        public String Color
        { get; set;}
        public String TypeShape
        { get; set; }
        public Double Perimeter
        { get; set; }
        public Double Area
        { get; set; }


        public override string ToString()
        {
            return "Color: " + color + ",  TypeShape: " + typeShape + ",  Perimeter:" + perimeter + ",  Area: " + area + ".";


        }
    }
}
