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
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] <= 0)
                {
					throw new ArgumentException("The value of the side cannot be negative");
				}
            }
            if (list.Length <= 0) throw new ArgumentException("No value entered");
            if (list.Length == 1) return shape = new Сircle(list);
            if (list.Length == 2) return shape = new Rectangle(list);
            if (list.Length == 3) return shape = new Triangle(list);
            if (list.Length == 4) return shape = new Triangle(list);
            else throw new ArgumentException("There is no such shape in this library");
        }
    }
}