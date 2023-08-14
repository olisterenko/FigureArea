namespace AreaCalculationTests;

[TestClass]
public class TriangleAreaTests
{
    [TestMethod]
    public void TestTriangleArea()
    {
        double a = 3;
        double b = 3;
        double c = 5;
        double expectedArea = 4.145781;

        Triangle triangle = new Triangle(a, b, c);
        double actualArea = triangle.Area();

        // Взяла такую точность только потому, что первый калькулятор в гугле дает точность до 6 знаков.
        Assert.AreEqual(expectedArea, actualArea, 1e-6, "Wrong area");
    }

    [TestMethod]
    public void TestOrthogonalTriangleArea()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double expectedArea = 6;

        Triangle triangle = new Triangle(a, b, c);
        double actualArea = triangle.Area();

        Assert.AreEqual(expectedArea, actualArea, 1e-6, "Wrong area");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException),
        "Calculation should not have been allowed.")]
    public void TestNonExistingTriangleArea()
    {
        double a = 3;
        double b = 3;
        double c = 7;
        Triangle triangle = new Triangle(a, b, c);
        double calculatedArea = triangle.Area();
    }
}