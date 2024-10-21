namespace AreaFigures;

public class Triangle: IFigure
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Sides must be greater than zero.");
        
        if (!IsValidTriangle(a, b, c))
            throw new ArgumentException("The sides don't form a valid triangle.");

        A = a;
        B = b;
        C = c;
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    public double GetArea()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    public bool IsRightTriangle()
    {
        double[] sides = { A, B, C };
        Array.Sort(sides);
        
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }
}