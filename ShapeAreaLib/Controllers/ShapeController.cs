using System.Collections.Generic;
using ShapeAreaLib.Models;
using ShapeAreaLib.Shapes;

namespace ShapeAreaLib.Controllers
{
    public class ShapeController
    {
        public static Shape Calc(params double[] list)
        {
            Shape shape;

            if (list.Length <= 0) throw new ArgumentException("Shape must have sides");
            if (list.Length == 1) return shape = new Сircle(list);
            if (list.Length == 2) return shape = new Rectangle(list);
            if (list.Length == 3) return shape = new Triangle(list);
            if (list.Length == 4) return shape = new Triangle(list);
            else throw new ArgumentException("Shape must have sides");
        }
    }
}