using System.Collections.Generic;
using ShapeAreaLib.Models;

namespace ShapeAreaLib
{
	public class Calculator
	{
	
		public static Shape Calc(params double[] list)
		{
			if (list.Length <= 0) throw new ArgumentException("Shape must have sides");
			//if (list.Length == 1)
			//{
			//	return Math.PI * Math.Pow(list[0], 2);
				
			//}
			//if(list.Length == 2)
			//{
			//	return list[0] * list[1];
			//}
			if (list.Length == 3)
			{
				Shape shape= new Tringle(list);
				return shape;
			}
			//if(list.Length == 4)
			//{
			//	return new Shape();
			//}
			else throw new ArgumentException("Shape must have sides");
		}




		

	}
}