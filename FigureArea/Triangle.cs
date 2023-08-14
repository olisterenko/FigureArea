namespace FigureArea;

public class Triangle : IAreaCalculatable
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;

        if (a + b < c || a + c < b || b + c < a)
        {
            throw new ArgumentException("The sum of two side lengths should exceed the third side length");
        }
    }

    /// <summary>
    /// Вычисляет площадь треугольника. 
    /// </summary>
    /// <returns> Площадь треугольника. </returns>
    public double Area()
    {
        if (IsOrthogonal())
        {
            /* Можно было бы в проверке на прямоугольность сделать так, чтобы _c, например, всегда была гипотенузой,
             но выглядит странно по отношению к пользователю. */
            if (_a > _b && _a > _c)
            {
                return 0.5 * _b * _c;
            }

            if (_b > _a && _b > _c)
            {
                return 0.5 * _a * _c;
            }

            return 0.5 * _a * _b;
        }

        double semiPerimeter = (_a + _b + _c) * 0.5;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));
    }

    /// <summary>
    /// Проверяет треугольник на прямоугольность. 
    /// </summary>
    /// <returns> true, если прямоугольный. </returns>
    public bool IsOrthogonal()
    {
        if (_a > _b && _a > _c && Math.Abs(_a * _a - (_b * _b + _c * _c)) < 1e-6)
        {
            return true;
        }

        if (_b > _a && _b > _c && Math.Abs(_b * _b - (_a * _a + _c * _c)) < 1e-6)
        {
            return true;
        }

        return _c > _a && _c > _b && Math.Abs(_c * _c - (_a * _a + _b * _b)) < 1e-6;
    }
}