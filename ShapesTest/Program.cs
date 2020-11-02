using System;
namespace ShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the desired Shape to get the area: ");
            string name = Console.ReadLine();
            if (name == "Rectangle")
            {
                name = "Rectangle";
                Console.Write("Enter length of the Rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter breadth of the Rectangle: ");
                double breadth = Convert.ToDouble(Console.ReadLine());
                Rectangle rectangle = new Rectangle(length, breadth, name);
                Console.WriteLine($"The rectangle araea of length: {length} and breadth: {breadth} is {rectangle.Area()}");
            }
            else if (name == "Triangle")
            {
                name = "Triangle";
                Console.Write("Enter base of the triangle: ");
                double tbase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter height of the triangle: ");
                double height = Convert.ToDouble(Console.ReadLine());
                Triangle triangle = new Triangle(tbase, height, name);
                Console.WriteLine($"The triangle araea of length: {tbase} and height: {height} is {triangle.Area()}");
            }
            else if (name == "Square")
            {
                name = "Square";
                Console.Write("Enter length of the square: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Square square = new Square(length, name, 0.0);
                Console.WriteLine($"The rectangle araea of length: {length} is {square.Area()}");
            }
            else if (name == "Cube")
            {
                name = "Cube";
                Console.Write("Enter length of the cube side: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Cube cube = new Cube(length, name, 0.0);
                Console.WriteLine($"The cube araea of length: {length} is {cube.Area()}");
            }
            else
            {
                Console.WriteLine("Shape not found, Try typing the first letter of the shape in Uppercase");
            }
        }
    }
}