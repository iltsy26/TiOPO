using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_TiOPO
{
    public class Ellips : Geometria
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

        public double Ellipe_S()
        {
            return Math.PI * Axis_A * Axis_B;
        }

        public double Ellipe_P()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(Axis_A, 2) * Math.Pow(Axis_B, 2)) / 2);
        }
    }
}
