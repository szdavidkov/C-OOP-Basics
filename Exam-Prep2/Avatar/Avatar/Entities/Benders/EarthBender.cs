public class EarthBender : Bender
{
    private decimal groundSaturation;


    public EarthBender(string name, int power, decimal groundSaturation) : base(name, power)
    {
        this.groundSaturation = groundSaturation;
    }

    public override decimal GetPower() => this.groundSaturation * this.Power;
    public override string ToString()
    {
        return $"{base.ToString()}, Ground Saturation: {this.groundSaturation:f2}";
    }
}

