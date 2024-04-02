using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguraProgra
{
    internal abstract class Shape
    {
        protected string type;

        public abstract float CalculateArea();

        public string GetShapeType()
        {
            return type;
        }
    }
}
