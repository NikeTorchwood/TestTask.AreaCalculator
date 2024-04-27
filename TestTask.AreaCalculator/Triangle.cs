namespace TestTask.AreaCalculator;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        var isTriangle = sideA + sideB <= sideC;
        if (isTriangle)
        {
            throw new ArgumentException("Треугольник не может сущестовать с такими сторонами",
                nameof(isTriangle));
        }

        _sideA = sideA > 0 
            ? sideA 
            : throw new ArgumentException("Сторона меньше или равна нулю", nameof(sideA));
        _sideB = sideB > 0
            ? sideB
            : throw new ArgumentException("Сторона меньше или равна нулю", nameof(sideB));
        _sideC = sideC > 0
            ? sideC
            : throw new ArgumentException("Сторона меньше или равна нулю", nameof(sideC));
        IsRightTriangle = CheckTriangleForRightAngle();
    }
    public bool IsRightTriangle { get; set; }
    public double GetArea()
    {
        var p = (_sideA + _sideB + _sideC) * 0.5;
        var squareOfResult = p * (p - _sideA) * (p - _sideB) * (p - _sideC);
        var result = Math.Sqrt(squareOfResult);
        return Math.Round(result, 2, MidpointRounding.ToZero);
    }

    private bool CheckTriangleForRightAngle()
    {
        return Math.Abs(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) - Math.Pow(_sideC, 2)) < 0.001;
    }
}