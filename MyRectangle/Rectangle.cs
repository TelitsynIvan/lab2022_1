namespace MyRectangle;

public class Rectangle
{
    public double side1;
    public double side2;

    public Rectangle(double sidea, double sideb)
    {
        side1 = sidea;
        side2 = sideb;
    }

    public double AreaCalculator()
    {
        return side1 * side2;
    }

    public double PerimeterCalculator()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return this.AreaCalculator(); }
    }

    public double Perimeter
    {
        get { return this.PerimeterCalculator(); }
    }
}