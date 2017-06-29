using System;
using System.Collections.Generic;


namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars= new Dictionary<string,Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var model = input[0];
                var fuelAmount = int.Parse(input[1]);
                var fuelFor1Kilometer = double.Parse(input[2]);
                var car = new Car(model,fuelAmount,fuelFor1Kilometer);

                cars.Add(model,car);
            }
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var tokens = inputLine.Split(' ');
                var carModel = tokens[1];
                var distance = int.Parse(tokens[2]);

                var currentCar = cars[carModel];

                currentCar.Drive(distance);
                cars[carModel] = currentCar;
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.DistanceTravelled}");
            }
        }
    }
}
