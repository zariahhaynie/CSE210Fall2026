using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("orange", 27);
        Console.WriteLine("Square:");
        Console.WriteLine(square.GetColor());
        Console.WriteLine($"Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("turquoise", 74, 300);
        Console.WriteLine("Rectangle:");
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine($"Area: {rectangle.GetArea()}");

        Circle circle = new Circle("magenta", 90);
        Console.WriteLine("Circle:");
        Console.WriteLine(circle.GetColor());
        Console.WriteLine($"Area: {circle.GetArea()}");

    }
}