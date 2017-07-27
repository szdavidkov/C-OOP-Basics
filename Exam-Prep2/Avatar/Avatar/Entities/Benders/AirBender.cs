using System.Runtime.InteropServices;

public class AirBender : Bender
{
    private decimal aerialIntegirty;

    public AirBender(string name, int power, decimal aerialIntegirty) : base(name,power)
    {
        this.aerialIntegirty = aerialIntegirty;
    }

    public override decimal GetPower() => this.aerialIntegirty * this.Power;

    public override string ToString()
    {
        return $"{base.ToString()}, Aerial Integrity: {this.aerialIntegirty:f2}";
    }
}

