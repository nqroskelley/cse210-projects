using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Yellow", 3, 2);
        Circle circle = new Circle("Blue", 4);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
    }
}