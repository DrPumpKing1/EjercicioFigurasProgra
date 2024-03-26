using EjercicioFiguraProgra;

bool continueFlag = true;

Controller controller = new Controller();

while (continueFlag)
{
    Shape? shape = controller.ShapeSelection();

    if(shape == null) continue;

    float shapeArea = shape.CalculateArea();

    Console.WriteLine($"{shape.GetShapeType()}'s area is {shapeArea}");

    continueFlag = controller.ExitMenu();
}
