using ShapeManagement;

List<Shape> shapes = new List<Shape>();

Console.Write("Enter radius for Circle: ");
double radius = Convert.ToDouble(Console.ReadLine());
Circle circle = new Circle(radius);
shapes.Add(circle);

Console.Write("Enter width for Rectangle: ");
double width = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter height for Rectangle: ");
double height = Convert.ToDouble(Console.ReadLine());
Rectangle rectangle = new Rectangle(width, height);
shapes.Add(rectangle);

foreach (var shape in shapes)
{
    Console.WriteLine($"Area of {shape.GetType().Name}: {shape.CalculateArea()}");
    Console.WriteLine($"Perimeter of {shape.GetType().Name}: {shape.CalculatePerimeter()}");
    Console.WriteLine();
}
