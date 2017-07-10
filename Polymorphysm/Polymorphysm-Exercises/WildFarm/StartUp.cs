using System;
using System.Configuration;

public class StartUp
{
    public static void Main()
    {

        string animalInfo;
        while ((animalInfo = Console.ReadLine()) != "End")
        {
            var foodInfo = Console.ReadLine().Split(' ');
            var animalTokens = animalInfo.Split(' ');

            var foodType = foodInfo[0];
            var foodQuantity = int.Parse(foodInfo[1]);
            Food food = null;

            if (foodType == "Vegetable")
            {
                food = new Vegetable(foodQuantity);
            }
            else
            {
                food = new Meat(foodQuantity);
            }

            var animalType = animalTokens[0];
            var animalName = animalTokens[1];
            var animalWeight = double.Parse(animalTokens[2]);
            var animalLivingReagon = animalTokens[3];


            Animal animal = null;

            if (animalTokens.Length == 5)
            {
                var catBreed = animalTokens[4];
                animal = new Cat(animalName,animalType,animalWeight,animalLivingReagon,catBreed);
            }
            switch (animalType)
            {
                case "Tiger":
                    animal = new Tiger(animalName,animalType,animalWeight,animalLivingReagon);
                    break;
                case "Zebra":
                    animal = new Zebra(animalName,animalType,animalWeight,animalLivingReagon);
                    break;
                case "Mouse":
                    animal = new Mouse(animalName,animalType,animalWeight,animalLivingReagon);
                    break;
            }

            animal.MakeSound();
            animal.EatFood(food);
            Console.WriteLine(animal);
        }
    }
}
