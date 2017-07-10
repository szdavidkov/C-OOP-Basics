using System;

public class Tiger : Felime
{
    public Tiger(string name, string type, double weight, string region) : base(name, type, weight, region)
    {
    }

    public override void EatFood(Food food)
    {
        if (food.FoodType != "Meat")
        {
            Console.WriteLine($"{this.AnimalType}s are not eating that type of food!");
        }
        else
        {
            this.FoodEaten += food.Quantity;
        }
    }

    public override void MakeSound()
    {
        Console.WriteLine("ROAAR!!!");
    }
}
