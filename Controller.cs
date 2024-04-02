using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguraProgra
{
    internal class Controller
    {
        public Shape? ShapeSelection()
        {
            Shape shape;

            Console.WriteLine("Select a shape from the list");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Triangle");
            Console.WriteLine("Type either the number or the shape's name");

            string shapeName = Console.ReadLine();
            
            if(shapeName != null) shapeName = shapeName.Trim().ToLower();

            if ( shapeName == "rectangle" || shapeName == "1")
            {
                RectangleMenu(out shape);

                return shape;
            } 
            
            else if (shapeName == "square" || shapeName == "2")
            {
                SquareMenu(out shape);

                return shape;
            }
            
            else if (shapeName == "circle" || shapeName == "3")
            {
                CircleMenu(out shape);


                return shape;
            }
            
            else if (shapeName == "triangle" || shapeName == "4")
            {
                TriangleMenu(out shape);

                return shape;
            } 
            
            else
            {
                Console.WriteLine("Not a valid shape enter, type it again");

                return null;
            }
        }

        public void RectangleMenu(out Shape shape)
        {
            float b, h;
            
            Console.WriteLine("Enter Rectangle's base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rectangle's height");
            h = float.Parse(Console.ReadLine());

            shape = new Rectangle(b, h);
        }

        public void SquareMenu(out Shape shape)
        {
            float l;

            Console.WriteLine("Enter Square's side length");
            l = float.Parse(Console.ReadLine());

            shape = new Square(l);
        }

        public void CircleMenu(out Shape shape)
        {
            float r;

            Console.WriteLine("Enter Circle's radius");
            r = float.Parse(Console.ReadLine());

            shape = new Circle(r);
        }

        public void TriangleMenu(out Shape shape)
        {
            float b, h;

            Console.WriteLine("Enter Triangle's base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Triangle's height");
            h = float.Parse(Console.ReadLine());

            shape = new Triangle(b, h);
        }

        public bool ExitMenu()
        {
            while (true)
            {
                Console.WriteLine("Make another area calculation (Yes/No)");

                string answer = Console.ReadLine();

                if (answer == null) return false;

                answer = answer.Trim().ToLower();

                if (answer == "yes" || answer == "y") return true;
                else if (answer == "no" || answer == "n") return false;
            }
        }
    }
}
