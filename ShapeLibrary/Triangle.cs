namespace ShapeLibrary;

/// <summary>
/// Создадим класс для треугольника, который также реализует интерфейс IShape.
/// Этот класс будет содержать метод для проверки, является ли треугольник прямоугольным, и метод для вычисления площади с использованием формулы Герона
/// </summary>
public class Triangle:IShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;

        if (!IsValidTriangle())
            throw new ArgumentException("Стороны не могут образовать треугольник.");
    }

    public double GetArea()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
    
    public bool IsRightAngled()
    {
        double[] sides = { A, B, C };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.0001;
    }

    private bool IsValidTriangle()
    {
        return A + B > C && A + C > B && B + C > A;
    }
}