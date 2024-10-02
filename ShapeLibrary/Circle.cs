namespace ShapeLibrary;

/// <summary>
/// Класс круга который реализует интерфейс IShape
/// </summary>
public class Circle:IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}