namespace AreaFigures;

public class Circle: IFigure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException("Radius must be greater than zero.");
        
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}