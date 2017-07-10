using System;

public class Cat : Felime
{
    private string breed;
    public Cat(string name, string type, double weight, string region, string breed) : base(name, type, weight, region)
    {
        this.Breed = breed;
    }

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public override void EatFood(Food food)
    {
        this.FoodEaten += food.Quantity;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meowwww");
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
