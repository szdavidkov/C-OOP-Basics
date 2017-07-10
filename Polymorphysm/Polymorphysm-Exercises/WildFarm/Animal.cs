
using System;

public abstract class Animal
{
    private string animalName;
    private string animalType;
    private double animalWeight;
    private int foodEaten;

    public Animal(string name , string type,double weight)
    {
        this.AnimalName = name;
        this.AnimalType = type;
        this.AnimalWeight = weight;
    }

    public string AnimalName
    {
        get { return this.animalName; }
        set { this.animalName = value; }
    }

    public string AnimalType
    {
        get { return this.animalType; }
        set { this.animalType = value; }
    }

    public double AnimalWeight
    {
        get { return this.animalWeight; }
        set { this.animalWeight = value; }
    }

    public int FoodEaten
    {
        get { return this.foodEaten; }
        set { this.foodEaten = value; }
    }

    public abstract void MakeSound();
    public abstract void EatFood(Food food);

}
