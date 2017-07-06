
using System;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public double Radius
    {
        get { return this.radius; }
        set { this.radius = value; }
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override string Draw()
    {
        return "Circle";
    }
}
