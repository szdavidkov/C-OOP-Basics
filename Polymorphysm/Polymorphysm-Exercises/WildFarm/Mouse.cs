
using System;

public class Mouse : Mammal
{
    public Mouse(string name, string type, double weight, string region) : base(name, type, weight, region)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("SQUEEEAAAK!");
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
}
