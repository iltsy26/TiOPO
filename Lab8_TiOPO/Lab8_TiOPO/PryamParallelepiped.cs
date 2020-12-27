using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_TiOPO
{
    public class PryamParallelepiped : Mnogougolnik
    {

        protected double A;
        protected double B;
        protected double C;

        public PryamParallelepiped(String pFigName, String pFigColor, Double pA, Double pB, Double pC)
                            : base(pFigName, pFigColor)
        {
            A = pA;
            B = pB;
            C = pC;
            Shape = 8;
            Vertex = 12;
        }
        public override double? Mnogougolnik_S()
        {
            return (this.A * this.B + this.A * this.C + this.C * this.B) * 2;
        }

        public override double? Mnogougolnik_V()
        {
            return this.A * this.B * this.C;
        }

        public override double? Mnogougolnik_L()
        {
            return (this.A + this.B + this.C) * 4;
        }

        public override double? Mnogougolnik_D()
        {
            return Math.Pow(this.A, 2) + Math.Pow(this.B, 2) + Math.Pow(this.C, 2);
        }
    }
}
