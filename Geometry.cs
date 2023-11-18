using System;

namespace GeometryLibrary
{
    public class Shape
    {
        internal double area;

        public double getArea()
        {
            return this.area;
        }
    }

    public class Circle : Shape
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
            this.area = Math.Round(Math.PI * Math.Pow(radius, 2));
        }
    }

    public class Triangle : Shape
    {
        public double side1;
        public double side2;
        public double side3;
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

            double p = (side1 + side2 + side3) / 2;
            this.area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
    }

    public class Rectangle : Shape
    {
        public double width;
        public double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            
            this.area = this.width * this.height;
        }
    }
}
