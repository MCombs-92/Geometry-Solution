using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Rectangle {
		public double Length { get; set; }
		public double Width { get; set; }

		public double GetArea() {
			return Length * Width;
		}

		public double GetPerimeter() {
			return (Length * 2) + (Width * 2);
		}

		public void Print() {
			Console.WriteLine($"A rectangle with a Length of {Length} and Width of {Width} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}
