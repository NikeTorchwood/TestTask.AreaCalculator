using TestTask.AreaCalculator;
using Xunit;

namespace TestTask.Tests;
public class CircleAreaTest
{
    [Fact]
    public void CreateCircle()
    {
        var r = 8;

        var result = new Circle(r);

        Assert.NotNull(result);
    }

    [Fact]
    public void CreateSecondCircle()
    {
        var r = -1;

        Assert.Throws<ArgumentException>((() => new Circle(r)));
    }

    [Fact]
    public void GetCircleAreaFirstTest()
    {
        var r = 1;

        var circle = new Circle(r);
        var result = circle.GetArea();

        Assert.Equal(3.14, result);
    }
    [Fact]
    public void GetCircleAreaSecondTest()
    {
        var r = 8;

        var circle = new Circle(r);
        var result = circle.GetArea();

        Assert.Equal(201.06, result);
    }
}

