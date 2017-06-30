class Box
{
    private double lenght;
    private double widht;
    private double height;

    public Box(double lenght, double widht, double height)
    {
        this.lenght = lenght;
        this.widht = widht;
        this.height = height;
    }

    public double Lenght
    {
        get { return this.lenght; }
    }

    public double Widht
    {
        get { return this.widht; }
    }

    public double Height
    {
        get { return this.height; }
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

