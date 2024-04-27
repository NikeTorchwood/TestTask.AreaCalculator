using Math = System.Math;

namespace TestTask.AreaCalculator;
public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("radius не может быть меньше нуля", nameof(radius));
        }
        _radius = radius;
    }
    public double GetArea()
    {
        var result = Math.PI * Math.Pow(_radius, 2);
        return Math.Round(result, 2, MidpointRounding.ToZero);
    }
}