namespace AreaCalculationTests;

[TestClass]
public class RightTriangleTests
{
    [TestMethod]
    public void TestRightTriangle()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        bool expectedResult = true;

        Triangle triangle = new Triangle(a, b, c);
        bool actualResult = triangle.IsRight();

        Assert.AreEqual(expectedResult, actualResult, "It is a right triangle.");
    }

    [TestMethod]
    public void TestList()
    {
        var figures = new List<Triangle>
        {
            new Triangle(4, 5, 3),
            new Triangle(5, 4, 3),
            new Triangle(3, 3, 5)
        };

        var actualAreas = new List<bool> {true, true, false};

        var expectedAreas = figures.Select(figure => figure.IsRight()).ToList();

        CollectionAssert.AreEqual(expectedAreas, actualAreas, "Incorrect result of the check.");
    }
}