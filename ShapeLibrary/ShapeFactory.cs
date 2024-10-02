namespace ShapeLibrary;

/// <summary>
/// Для реализации возможности вычисления площади без знания типа фигуры во время компиляции, можно использовать фабрику
/// То есть для вычисление площади фигуры без знания типа фигуры в compile-time
/// </summary>
public static class ShapeFactory
{
    public static IShape CreateShape(string shapeType, params double[] parameters)
    {
        return shapeType.ToLower() switch
        {
            "circle" => new Circle(parameters[0]),
            "triangle" => new Triangle(parameters[0], parameters[1], parameters[2]),
            _ => throw new ArgumentException("Unknown shape type"),
        };
    }
}