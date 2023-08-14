namespace FigureArea;

public class Circle : IAreaCalculatable
{
    private readonly double _radius;

    public Circle(double radius)
    {
        // Считаю, что круг все-таки не точка.
        if (radius <= 0)
        {
            throw new ArgumentException("Radius should be a positive number.");
        }

        _radius = radius;
    }

    /// <summary>
    /// Вычисляет площадь круга. 
    /// </summary>
    /// <returns> Площадь круга. </returns>
    public double Area()
    {
        return Math.PI * _radius * _radius;
    }
}