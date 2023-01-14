using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Shape
    {
        protected String color;
        protected String typeShape;
        protected  Shape(String Color,String TypeShape)
        {
            this.color = Color;
            this.typeShape = TypeShape;
        }
        public String Color
        { get; set; }
        public String TypeShape
        { get; set; }
    }
}
