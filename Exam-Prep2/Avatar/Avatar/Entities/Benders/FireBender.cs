public class FireBender : Bender
{
    private decimal heatAggression;


    public FireBender(string name, int power, decimal heatAggression) : base(name, power)
    {
        this.heatAggression = heatAggression;
    }

    public override decimal GetPower() => this.heatAggression * this.Power;

    public override string ToString()
    {
        return $"{base.ToString()}, Heat Aggression: {this.heatAggression:f2}";
    }
}

