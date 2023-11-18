using System;
using GeometryLibrary;

namespace Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle(6);
            Shape shape2 = new Triangle(3, 4, 5);
            Shape shape3 = new Rectangle(5,7);

            Console.WriteLine( "Shape 1 is a " + shape1.GetType().Name + " with an area of " + shape1.getArea() );
            Console.WriteLine( "Shape 2 is a " + shape2.GetType().Name + " with an area of " + shape2.getArea() );
            Console.WriteLine( "Shape 3 is a " + shape3.GetType().Name + " with an area of " + shape3.getArea() );

            if( shape2.GetType() == typeof(Rectangle) )
            {
                Console.WriteLine("Shape 2 is a Rectangle");
            }
            else
            {
                Console.WriteLine("Shape 2 is NOT a Rectangle");
            }
        }
    }
}
