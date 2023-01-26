using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShapeAreaLib.Models
{
    internal class Triangle:Shape
	{
		public Triangle(double[] list)
		{
			this.Area = CalculateSquare(list);
			this.Message = "Это треугольник";
			if (IsRectangular(list)==true) this.Message += ", он прямоугольный";
		}

		public static bool IsRectangular(double[] list)
		{
			double temp;
			for (var i = 1; i < list.Length; i++)
			{
				for (var j = 0; j < list.Length - i; j++)
				{
					if (list[j] > list[j + 1])
					{
						temp = list[j];
						list[j] = list[j+1];
						list[j+1] = temp;
					}
				}
			}
			return Math.Pow(list[2], 2) == Math.Pow(list[0], 2) + Math.Pow(list[1], 2);

		}
		protected override double CalculateSquare(double[] list)
		{
			if (list[0] + list[1] > list[2] && list[0] + list[2] > list[1] && list[1] + list[2] > list[0])
			{
				double sum = 0;
				for (int i = 0; i < list.Length; i++)
				{

					sum += list[i];

				}
				double p = sum / 2;

				return Math.Sqrt(p * (p - list[0]) * (p - list[1]) * (p - list[2]));
			}
			else throw new ArgumentException("Shape couldn't exist");
		}

	}
}
