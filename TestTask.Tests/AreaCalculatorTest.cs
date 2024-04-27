using TestTask.AreaCalculator;
using Xunit;

namespace TestTask.Tests;
public class AreaCalculatorTest
{
    
    
    [Fact]
    public void CalculateCircle()
    {
        var r = 8;

        var circle = new Circle(r);
        var result = ShapeCalculator.CalculateArea(circle);

        Assert.Equal(201.06, result);
    }
    [Fact]
    public void CalculateTriangle()
    {
        var a = 3;
        var b = 4;
        var c = 5;

        var triangle = new Triangle(a, b, c);
        var result = ShapeCalculator.CalculateArea(triangle);

        Assert.Equal(6, result);
    }
}

