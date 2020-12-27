using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_TiOPO
{
	class Ellips : Geometria, IDrawable
	{
		protected double Axis_A;
		protected double Axis_B;

		public Ellips(string pFigName, string pFigColor, double pA, double pB)
						: base(pFigName, pFigColor)
		{
			Axis_A = pA;
			Axis_B = pB;
		}

		public override string getFigData()
		{
			return "Эллипс: " + this.data;
		}

		public void Draw()
		{
			String s =
							"          ******* \n" +
							"      **          **\n" +
							"    **              **\n" +
							"  **                  **\n" +
							" **                    **\n" +
							"**                      **\n" +
							"**                      **\n" +
							" **                    **\n" +
							"  **                  **\n" +
							"    **              **\n" +
							"      **          **\n" +
							"          ******* \n";
			Console.WriteLine(s);
		}

		public string Str()
		{
			return "Фигура: Эллипс " + "A = " + Axis_A + "B = " + Axis_B;
		}
	}

}
