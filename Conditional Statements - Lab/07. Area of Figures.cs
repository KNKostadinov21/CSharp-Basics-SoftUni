using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            string shapeSquare = "square";
            string shapeRectangle = "rectangle";
            string shapeCircle = "circle";
            string shapeTriangle = "triangle";
            double size;
            if (shape == shapeSquare)
            {
                double side = double.Parse(Console.ReadLine());
                size = side * side;
                Console.WriteLine($"{size:F3}");
            }
            if (shape == shapeRectangle)
            {
                double sideOne = double.Parse(Console.ReadLine());
                double sideTwo = double.Parse(Console.ReadLine());
                size = sideOne * sideTwo;
                Console.WriteLine($"{size:F3}");
            }
            if (shape == shapeCircle)
            {
                double side = double.Parse(Console.ReadLine());
                size = side * side * Math.PI;
                Console.WriteLine($"{size:F3}");
            }
            if (shape == shapeTriangle)
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                size = (side * height) / 2;
                Console.WriteLine($"{size:F3}");
            }
        }
    }
}