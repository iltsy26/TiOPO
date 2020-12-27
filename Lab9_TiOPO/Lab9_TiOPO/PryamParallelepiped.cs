using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_TiOPO
{
	class PryamParallelepiped : Mnogougolnik, IDrawable
	{
		protected double A;
		protected double B;
		protected double C;

		public PryamParallelepiped(string pFigName, string pFigColor, double pA, double pB, double pC)
						: base(pFigName, pFigColor)
		{
			A = pA;
			B = pB;
			C = pC;
			Shape = 8;
			Vertex = 12;
		}

		public void Draw()
		{
			string s =
							"    *********\n" +
							"   *       **\n" +
							"  *       * *\n" +
							" *       *  *\n" +
							"*********   *\n" +
							"*       *  *\n" +
							"*       * *\n" +
							"*       **\n" +
							"*********\n";
			Console.WriteLine(s);
		}

		public string Str()
		{
			return "Фигура: Прямоугольный параллелепипед " + "A = " + A + "B = " + B + "С = " + C;
		}
	}
}
