using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguraProgra
{
    internal class Square : Shape, IShapeAreaCalculator, IShapePerimeterCalculator
    {
        private float l;

        public float Length { get { return l; } }

        public Square(float l) 
        {
            this.l = l;

            type = "Square";
        }

        public float CalculateArea()
        {
            return l * l;
        }

        public float CalculatePerimeter()
        {
            return l * 4;
        }
    }
}
