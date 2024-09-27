using GeometryCalculator.Entity;

namespace GeometryCalculator.Tests;

public class Tests
{
    [Test]
    public void CalculateAreaCircle_InputRadiusThree_ReturnTwentyEightPointThree()
    {
        Circle circle = new(3);
        Assert.AreEqual(28.3,   circle.CalculateArea());
    }

    [Test]
    public void CalculateAreaTriangle_InputSidesThreeFourFive_ReturnSix()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(6, triangle.CalculateArea());
    }

    [Test]
    public void IsRightTriangle_InputSidesThreeFourFive_ReturnTrue()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(true, triangle.IsRightTriangle());
    }
    
    [Test]
    public void IsRightTriangle_InputSidesThreeFourSix_ReturnFalse()
    {
        Triangle triangle = new Triangle(3, 4, 6);
        Assert.AreEqual(false, triangle.IsRightTriangle());
    }
}