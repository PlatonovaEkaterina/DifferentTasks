namespace AreaFigures;

public class FigureFactory
{
    public static IFigure CreateCircle(double radius)
    {
        return new Circle(radius);
    }

    public static IFigure CreateTriangle(double sideA, double sideB, double sideC)
    {
        return new Triangle(sideA, sideB, sideC);
    }
}