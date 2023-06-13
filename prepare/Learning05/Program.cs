using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Yellow", 3, 2);
        Circle circle = new Circle("Blue", 4);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
          Console.WriteLine(shape.GetColor());
          Console.WriteLine(shape.GetArea());
        }
    }
}