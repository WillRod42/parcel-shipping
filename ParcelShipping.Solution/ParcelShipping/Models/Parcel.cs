using System;
using System.Collections.Generic;

namespace ParcelShipping.Models
{
	public class Parcel
	{
		public int Width { get; }
		public int Height { get; }
		public int Length { get; }
		public int Weight { get; }
		
		private const float PriceMod = 0.2f;

		public Parcel(int weight, int width, int height, int length)
		{
			Weight = weight;
			Width = width;
			Height = height;
			Length = length;
		}

		public int Volume()
		{
			return Width * Length * Height;
		}

		public float CostToShip()
		{
			return (float)Math.Round((double)(PriceMod * Weight * Volume()), 2);
		}

		public string Dimensions()
		{
			return $"${Length}in x ${Width}in x ${Height}in";
		}

		public string PrintWeight()
		{
			return Weight + "lbs";
		}
	}
}
