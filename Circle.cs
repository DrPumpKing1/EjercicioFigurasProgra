using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguraProgra
{
    internal class Circle : Shape, IShapeAreaCalculator, IShapePerimeterCalculator
    {
        private float r;

        public float Radius { get {  return r; } }
        
        public Circle(float r) 
        {
            this.r = r;

            type = "Circle";

        }

        public float CalculateArea()
        {
            return MathF.PI * r * r;
        }

        public float CalculatePerimeter()
        {
            return 2f * MathF.PI * r;
        }
    }
}
