using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_TiOPO
{
    public class Mnogougolnik : Geometria
    {

        protected int? Shape;
        protected int? Vertex;
        protected string S_V;

        //public Mnogougolnik()
        //                : base()
        //{
        //Shape = null;
        //Vertex = null;
        //S_V = "Shapes: " + Shape + " " + "Vertexes: " + Vertex;
        //}

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

        public virtual double? Mnogougolnik_S()
        {
            return null;
        }

        public virtual double? Mnogougolnik_P()
        {
            return null;
        }

        public virtual double? Mnogougolnik_V()
        {
            return null;
        }

        public virtual double? Mnogougolnik_L()
        {
            return null;
        }

        public virtual double? Mnogougolnik_D()
        {
            return null;
        }
    }
}
