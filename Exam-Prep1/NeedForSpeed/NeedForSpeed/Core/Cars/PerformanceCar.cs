using System;
using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    public List<string> AddOns;
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durrability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durrability)
    {
        this.HorsePower += horsepower * 50 / 100;
        this.Suspension -= suspension * 25 / 100;
        this.AddOns = new List<string>();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.Append(Environment.NewLine);

        if (this.AddOns.Count > 0)
        {
            sb.Append("Add-ons: " + string.Join(", ", AddOns));
        }
        else
        {
            
            sb.Append("Add-ons: None");
        }

        return sb.ToString().Trim();
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        this.AddOns.Add(addOn);
    }
}
