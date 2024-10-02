using ShapeLibrary;
using Xunit;
using Assert = Xunit.Assert;


namespace ShapeTests;

public class ShapeTests
{
    [Fact]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.Equal(Math.PI * 25, circle.GetArea(), 2);
    }
    [Fact]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.GetArea(), 2);
    }

    [Fact]
    public void RightAngledTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled());
    }

    [Fact]
    public void NonRightAngledTriangleTest()
    {
        var triangle = new Triangle(5, 6, 7);
        Assert.False(triangle.IsRightAngled());
    }
}