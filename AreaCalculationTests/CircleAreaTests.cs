namespace AreaCalculationTests;

[TestClass]
public class CircleAreaTests
{
    [TestMethod]
    public void TestExistingCircleArea()
    {
        double r = 3;
        double expectedArea = 28.27433;
        Circle circle = new Circle(r);
        double actualArea = circle.Area();

        // Взяла такую точность только потому, что первый калькулятор в гугле дает точность до 5 знаков.
        Assert.AreEqual(expectedArea, actualArea, 1e-5, "Wrong area");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException),
        "Calculation should not have been allowed.")]
    public void TestNonExistingCircleArea()
    {
        double r = 0;
        Circle circle = new Circle(r);
        double calculatedArea = circle.Area();
    }
}