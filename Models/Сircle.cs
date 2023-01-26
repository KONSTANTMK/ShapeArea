using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib.Models
{
	internal class Сircle : Shape
	{
		public Сircle(double[] list)
		{
			this.Area = CalculateSquare(list);
			this.Message = "Это круг";
		}
		protected override double CalculateSquare(double[] list)
		{
			return Math.PI* Math.Pow(list[0], 2);
		}
	}
}
