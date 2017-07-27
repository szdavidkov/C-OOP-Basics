using System;
using System.Text;

public class ShowCar : Car
{
    public int Stars { get; set; }
    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durrability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durrability)
    {
    }

    public override string ToString()   
    {
        var sb = new StringBuilder(base.ToString());
        sb.Append("\n");
        sb.Append($"{this.Stars} *");
        return sb.ToString().Trim();
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        this.Stars += tuneIndex;
    }
}
