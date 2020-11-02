using System;
namespace shapeTest
{
    public class shape
    {
        protected double x{get; set;}
        protected double y{get; set;}
        protected string name{get; set;}
        public Shape(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public virtual double Area()
        {
            return x * y;
        } 
    }
    public class Rectangle : Shape
    {
        public Rectangle(double x, double y, string name) : base(x, y, name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public override double Area()
        {
            return base.Area();
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double x, double y, string name) : base(x, y, name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public override double Area()
        {
            return 0.5 * x * y;
        }
    }
    public class Square : Shape
    {
        public Square(double x, string name, double y) : base(x, y, name)
        {
            this.x = x;
            this.name = name;
        }
        public override double Area()
        {
            return x * x;
        }
    }
    public class Cube : Shape
    {
        public Cube(double x, string name, double y) : base(x, y, name)
        {
            this.x = x;
            this.name = name;
        }
        public override double Area()
        {
            return 6.0 * x * x;
        }
    }
}