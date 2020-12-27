using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_TiOPO
{
	class Geometria
	{
		protected string figName;
		protected string figColor;
		protected string data;


		public Geometria(string pFigName, string pFigColor)
		{
			figName = pFigName;
			figColor = pFigColor;
			data = figName + " " + figColor;
		}

		public virtual string getFigData()
		{
			return this.data;
		}
	}
}
