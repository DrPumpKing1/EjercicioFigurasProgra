using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguraProgra
{
    internal class Square : Shape
    {
        private float l;

        public float Length { get { return l; } }

        public Square(float l) 
        {
            this.l = l;

            type = "Square";
        }

        public override float CalculateArea()
        {
            return l * l;
        }
    }
}
