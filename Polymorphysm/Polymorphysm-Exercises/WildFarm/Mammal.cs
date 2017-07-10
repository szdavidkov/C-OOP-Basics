
public abstract class Mammal : Animal
{
    private string livinRegion;



    public Mammal(string name, string type, double weight, string region) : base(name, type, weight)
    {
        this.LivingRegion = region;
    }
    public string LivingRegion
    {
        get { return this.livinRegion; }
        set { this.livinRegion = value; }
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
