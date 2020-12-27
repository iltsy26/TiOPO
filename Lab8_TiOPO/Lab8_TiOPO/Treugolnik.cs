using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_TiOPO
{
    public class Treugolnik : Mnogougolnik
    {

        protected double A;
        protected double B;
        protected double C;

        public Treugolnik(String pFigName, String pFigColor, Double pA, Double pB, Double pC)
                        : base(pFigName, pFigColor)
        {
            A = pA;
            B = pB;
            C = pC;
            Shape = 3;
            Vertex = 3;
        }

        public override double? Mnogougolnik_P()
        {
            return this.A + this.B + this.C;
        }

        public override double? Mnogougolnik_S()
        {
            double Prmtr = Convert.ToDouble(Mnogougolnik_P());
            return Math.Sqrt(Prmtr / 2 * (Prmtr / 2 - this.A) 
                * (Prmtr / 2 - this.B) * (Prmtr / 2 - this.B));
        }
    }
}
