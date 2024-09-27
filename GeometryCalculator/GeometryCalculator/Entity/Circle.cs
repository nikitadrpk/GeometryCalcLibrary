using GeometryCalculator.BaseModel;
using GeometryCalculator.Constants;

namespace GeometryCalculator.Entity;

public class Circle : FigureBase
{
    private const float PI = 3.14f;
    private readonly double _radius;
    
    public override double CalculateArea() => Math.Round(PI * Math.Pow(_radius, 2), 1);

    public Circle(double radius)
    {
        if (radius > 0)
        {
            _radius = radius;
        }
        else
        {
            throw new ArgumentException(ErrorMessage.ErrorMessageSizeRadius);
        }
    }
}