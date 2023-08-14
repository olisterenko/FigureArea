namespace AreaCalculationTests;

[TestClass]
public class ListAreaTests
{
    [TestMethod]
    public void TestListArea()
    {
        var figures = new List<IAreaCalculatable>();
        figures.Add(new Circle(3));
        figures.Add(new Triangle(3, 4, 5));
        figures.Add(new Triangle(3, 3, 5));

        var actualAreas = new List<double>();
        actualAreas.Add(28.27433);
        actualAreas.Add(6);
        actualAreas.Add(4.14578);

        var expectedAreas = figures.Select(figure => Math.Round(figure.Area(), 5)).ToList();

        CollectionAssert.AreEqual(expectedAreas, actualAreas, "Wrong area");
    }
}