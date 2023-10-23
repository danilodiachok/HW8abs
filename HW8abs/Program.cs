namespace HW8abs
{
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("Circle 1", 5.0));
            shapes.Add(new Square("Square 1", 4.0));
            shapes.Add(new Circle("Circle 2", 3.0));
            shapes.Add(new Square("Square 2", 2.0));

            
            Console.WriteLine("Shapes Infa:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }

            
            Shape maxPerimeterShape = shapes[0];
            foreach (Shape shape in shapes)
            {
                if (shape.Perimeter() > maxPerimeterShape.Perimeter())
                {
                    maxPerimeterShape = shape;
                }
            }
            Console.WriteLine($"\nThe largest perimeter is: {maxPerimeterShape.Name}");

            
            shapes.Sort();
            Console.WriteLine("\nShapes Sorted by Area:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }
        }
    }
}