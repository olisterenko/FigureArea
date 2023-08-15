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
        if (IsHypotenuse(_b, _c, _a))
        {
            return 0.5 * _b * _c;
        }

        if (IsHypotenuse(_a, _c, _b))
        {
            return 0.5 * _a * _c;
        }

        if (IsHypotenuse(_a, _b, _c))
        {
            return 0.5 * _a * _b;
        }

        double semiPerimeter = (_a + _b + _c) * 0.5;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));
    }

    /// <summary>
    /// Проверяет треугольник на прямоугольность. 
    /// </summary>
    /// <returns> true, если прямоугольный. </returns>
    public bool IsRight()
    {
        return IsHypotenuse(_a, _b, _c) || IsHypotenuse(_a, _c, _b)
                                        || IsHypotenuse(_b, _c, _a);
    }

    /// <summary>
    /// Проверяет, является ли последний параметр гипотенузой.
    /// </summary>
    /// <param name="leg1"> Предполагаемый катет. </param>
    /// <param name="leg2"> Предполагаемый катет. </param>
    /// <param name="hypotenuse"> Предполагаемая гипотенуза. </param>
    /// <returns> Результат проверки последнего параметра. </returns>
    private bool IsHypotenuse(double leg1, double leg2, double hypotenuse)
    {
        return hypotenuse > leg1 && hypotenuse > leg2 &&
               Math.Abs(hypotenuse * hypotenuse - (leg1 * leg1 + leg2 * leg2)) < 1e-6;
    }
}