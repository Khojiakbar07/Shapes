using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal interface Drawable
    {
        public void draw();
        public double area();
        public double perimeter();
    }
}
