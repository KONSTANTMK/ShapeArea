﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib.Models
{
	public abstract class Shape
	{
		public double Square;
		public string? Message;



		protected abstract double CalculateSquare(double[] list);
	}
}
