using System;

class Box
{
    private double lenght;
    private double widht;
    private double height;

    public Box(double lenght, double widht, double height)
    {
        this.Lenght = lenght;
        this.Widht = widht;
        this.Height = height;
    }

    public double Lenght
    {
        get { return this.lenght; }
        private set
        {
            if (lenght <= 0)
            {
                throw new ArgumentException("Lenght cannot be zero or negative.");
            }
            this.lenght = value;
        }
    }

    public double Widht
    {
        get { return this.widht; }
        private set
        {
            if (widht <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.widht = value;
        }
    }

    public double Height
    {
        get { return this.height; }
        private set
        {
            if (height <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public double CalculateVolume()
    {
        return this.height * this.widht * this.lenght;
    }

    public double CalculateLateralSurfaceArea()
    {
        return (2 * this.lenght * this.height) + (2 * this.widht * this.height);
    }

    public double CalculateSurfaceArea()
    {
        return (2 * this.lenght * this.widht) + (2 * this.lenght * this.height) + (2 * this.widht * this.height);
    }
}

