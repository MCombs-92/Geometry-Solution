using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Circle {

		public double Radius { get; set; }

		public double GetArea() {
			return 3.14159 * (Radius * Radius);
		}

		public double GetPerimeter() {
			return 3.14159 * (Radius * 2);
		}

		public void Print() {
			Console.WriteLine($"A circle with a radius of {Radius} has an area of {GetArea()} and a perimeter of {GetPerimeter()}");
		}
	}
}
