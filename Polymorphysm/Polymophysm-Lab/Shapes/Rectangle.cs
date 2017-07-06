
using System;

public class Rectangle: Shape
{
    private double height;
    private double width;

    public Rectangle(double height,double width)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public override double CalculateArea()
    {
        return Height * width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Height + 2 * width;
    }

    public override string Draw()
    {
        return "Rectangle";
    }
}
