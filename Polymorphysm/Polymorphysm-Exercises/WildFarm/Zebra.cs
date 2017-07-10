using System;

public class Zebra : Mammal
{
    public Zebra(string name, string type, double weight, string region) : base(name, type, weight, region)
    {
    }

    public override void EatFood(Food food)
    {
        if (food.FoodType != "Vegetable")
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
        Console.WriteLine("Zs");
    }
}
