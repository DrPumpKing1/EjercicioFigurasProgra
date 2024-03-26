using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguraProgra
{
    internal class Shape
    {
        protected string type; 

        public virtual float CalculateArea()
        {
            return 0f;
        }

        public string GetShapeType()
        {
            return type;
        }
    }
}
