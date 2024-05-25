using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 4);
        //Console.WriteLine(square.GetColor());
        //Console.WriteLine(square.GetArea());
        //Console.WriteLine();
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("pink", 3, 4);
        //Console.WriteLine(rectangle.GetColor());
        //Console.WriteLine(rectangle.GetArea());
        //Console.WriteLine();
        shapes.Add(rectangle);

        Circle circle = new Circle("green", 2);
        //Console.WriteLine(circle.GetColor());
        //Console.WriteLine(circle.GetArea());
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}