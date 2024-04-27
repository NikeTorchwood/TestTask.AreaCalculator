using TestTask.AreaCalculator;
using Xunit;

namespace TestTask.Tests;
public class TriangleAreaTest
{
    [Fact]
    public void CreateFirstTriangle()
    {
        var a = 8;
        var b = 5;
        var c = 9;

        var result = new Triangle(a, b, c);

        Assert.NotNull(result);
    }

    [Fact]
    public void CreateSecondTriangle()
    {
        var a = 8;
        var b = 5;
        var c = -1;


        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    [Fact]
    public void CreateThirdTriangle()
    {
        var a = 3;
        var b = 5;
        var c = 9;


        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Fact]
    public void GetAcuteAngledTriangleAreaTest()
    {
        var a = 8;
        var b = 5;
        var c = 9;

        var triangle = new Triangle(a, b, c);
        var result = triangle.GetArea();

        Assert.Equal(19.89, result);
    }

    [Fact]
    public void GetRightAngledTriangleAreaTest()
    {
        var a = 3;
        var b = 4;
        var c = 5;

        var triangle = new Triangle(a, b, c);
        var result = triangle.GetArea();

        Assert.Equal(6, result);
    }

    [Fact]
    public void GetObtuseAngledTriangleAreaTest()
    {
        var a = 2;
        var b = 3;
        var c = 4;

        var triangle = new Triangle(a, b, c);
        var result = triangle.GetArea();

        Assert.Equal(2.90, result);
    }
    [Fact]
    public void GetIsoscelesTriangleAreaTest()
    {
        var a = 4;
        var b = 6;
        var c = 6;

        var triangle = new Triangle(a, b, c);
        var result = triangle.GetArea();

        Assert.Equal(11.31, result);
    }

    [Fact]
    public void GetEquilateralTriangleAreaTest()
    {
        var a = 3;
        var b = 3;
        var c = 3;

        var triangle = new Triangle(a, b, c);
        var result = triangle.GetArea();

        Assert.Equal(3.89, result);
    }


}
