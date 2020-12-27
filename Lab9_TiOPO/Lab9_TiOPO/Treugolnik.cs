using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_TiOPO
{

	class Treugolnik : Mnogougolnik, IDrawable
	{
		protected double A;
		protected double B;
		protected double C;

		public Treugolnik(string pFigName, string pFigColor, double pA, double pB, double pC)
						: base(pFigName, pFigColor)
		{
			A = pA;
			B = pB;
			C = pC;
			Shape = 3;
			Vertex = 3;
		}

		public void Draw()
		{
			string s =
							"    *    \n" +
							"   * *   \n" +
							"  *   *  \n" +
							" ******* \n";
			Console.WriteLine(s);
		}

		public string Str()
		{
			return "Фигура: треугольник " + "A = " + A + "B = " + B + "C = " + C;
		}
	}
}
