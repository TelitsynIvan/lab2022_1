namespace TestProject2;


using NUnit.Framework;
using Figure;

public class Tests
{
    [Test]
    public void Setup()
    {
        Point.Point one = new(10, 10);
        Point.Point two = new(10, 15);
        Point.Point three = new(0, 0);
        Figure test = new(one, two, three);
        Assert.AreEqual(5, test.LengthSide(one, two));
    }

    [Test]
    public void Test1()
    {
        Point.Point one = new(0, 0);
        Point.Point two = new(0, 4);
        Point.Point three = new(3, 0);
        Figure test = new(one, two, three);
        Assert.AreEqual(12, test.PerimeterCalculator());
    }
}