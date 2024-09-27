using GeometryCalculator.BaseModel;
using GeometryCalculator.Constants;

namespace GeometryCalculator.Entity;

public class Triangle : FigureBase
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    
    public override double CalculateArea()
    {
       double semiPerimetr = (_sideA + _sideB + _sideC) / 2;
       
       double area = Math.Round(Math.Sqrt(semiPerimetr
                                            * (semiPerimetr - _sideA)
                                            * (semiPerimetr - _sideB)
                                            * (semiPerimetr - _sideC)), 1);

       return area;
    }
    
    public bool IsRightTriangle()
    {
        var sides = new[] { _sideA, _sideB, _sideC };
        Array.Sort(sides); 
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (IsTriangleExistence(sideA, sideB, sideC))
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        else
        {
            throw new ArgumentException(ErrorMessage.ErrorMessageSizeSideTriangle);
        }
    }

    private bool IsTriangleExistence(double sideA, double sideB, double sideC)
    {
        if (sideA + sideB < sideC)
            return false;
        if (sideA + sideC < sideB)
            return false;
        if (sideB + sideC < sideA)
            return false;

        return sideA > 0 && sideB > 0 && sideC > 0;
    }
}