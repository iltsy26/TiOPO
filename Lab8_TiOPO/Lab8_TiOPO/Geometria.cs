using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_TiOPO
{
    public class Geometria
    {
        protected string figName;
        protected string figColor;
        protected string data;

        public Geometria()
        {
            figName = "Неизвестно";
            figColor = "";
            data = figName + " " + figColor;
        }


        public Geometria(string pFigName, string pFigColor)
        {
            figName = pFigName;
            figColor = pFigColor;
        }

        public virtual string getFigData()
        {
            data = figName + " " + figColor;
            return this.data;
        }

        public string getName()
        {
            return this.figName;
        }
    }
}
