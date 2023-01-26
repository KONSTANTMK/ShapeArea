using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib.Models
{
	public class Tringle:Shape
	{
		public Tringle(double[] list)
		{
			this.Square = CalculateSquare(list);
			this.Message = "Это треугольник";
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
