using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Square {
		public double LengthofSides { get; set; }

		public double GetArea() {
			return LengthofSides * LengthofSides;
		}

		public double GetPerimeter() {
			return LengthofSides * 4;
		}

		public void Print() {
			Console.WriteLine($"A square with length {LengthofSides} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");

		}
	}
}
