using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib.Shapes
{
    public abstract class Shape
    {
        public double Area;
        public string? Message;
        protected abstract double CalculateSquare(double[] list);
    }
}
