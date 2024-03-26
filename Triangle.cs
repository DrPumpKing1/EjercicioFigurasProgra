using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguraProgra
{
    internal class Triangle : Shape
    {
        private float b;
        private float h;

        public float Base { get { return b; } }
        public float Height { get { return h; } }

        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;

            type = "Triangle";
        }

        public override float CalculateArea()
        {
            return b * h / 2;
        }
    }
}
