using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib.Shapes;

namespace ShapeAreaLib.Models
{
    internal class Rectangle : Shape
	{
		public Rectangle(double[] list)
		{
			this.Area = CalculateSquare(list);
			
		}
		protected override double CalculateSquare(double[] list)
		{
			if (list[0] == list[1]) this.Message = "Это квадрат";
			else this.Message = "Это прямоугольник";
			return list[0] * list[1];
			
		}
	}
}
