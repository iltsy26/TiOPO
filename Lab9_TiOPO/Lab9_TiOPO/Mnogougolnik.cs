using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_TiOPO
{
	class Mnogougolnik : Geometria
	{
		protected int? Shape;
		protected int? Vertex;
		protected string S_V;

		public Mnogougolnik(string pFigName, string pFigColor)
						: base(pFigName, pFigColor)
		{
			Shape = null;
			Vertex = null;
			S_V = "Shapes: " + Shape + " " + "Vertexes: " + Vertex;
		}

		public override string getFigData()
		{
			return "Многоугольник: " + this.data;
		}

		public string getMnogData()
		{
			return this.S_V;
		}
	}
}
