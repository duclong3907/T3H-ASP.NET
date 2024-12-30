
namespace ShapeManagement;

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Radius * Radius;

    public override double CalculatePerimeter() => 2 * Math.PI* Radius;
}
