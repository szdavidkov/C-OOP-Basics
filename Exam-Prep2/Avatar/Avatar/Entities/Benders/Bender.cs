public abstract class Bender
{
    private string name;
    private int power;

    public Bender(string name, int power)
    {

        this.name = name;
        this.power = power;
    }

    public int Power { get { return this.power; } set { this.power = value; } }
    public abstract decimal GetPower();

    public override string ToString()
    {
        var benderType = this.GetType().Name;
        var typeEnd = benderType.IndexOf("Bender");
        benderType = benderType.Insert(typeEnd," ");

        return $"{benderType}: {this.name}, Power: {this.Power}";
    }
}
