using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Program {
		static void Main(string[] args) {

			Square sqr = new Square();
			sqr.LengthofSides = 1.5;
			sqr.Print();
			//double area = sqr.GetArea();
			//double perimeter = sqr.GetPerimeter();
			//Console.WriteLine("Area is {0}, Perimeter is {1}", area, perimeter);

			Square sqr2 = new Square();
			sqr2.LengthofSides = 3.3;
			sqr2.Print();

			Rectangle Rec = new Rectangle();
			Rec.Length = 1.2;
			Rec.Width = 8.2;
			Rec.Print();

			Circle Circ = new Circle();

			Circ.Radius = 5;
			Circ.Print();

			Circle Circ1 = new Circle();

			Circ1.Radius = 10;
			Circ1.Print();


		}
	}
}
