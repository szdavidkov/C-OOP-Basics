using System;


public class StartUp
{
    public static void Main()
    {
            var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var busInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var carFuelQuantity = double.Parse(carInfo[1]);
            var carFuelConsuption = double.Parse(carInfo[2]);
            var carTankCapacity = double.Parse(carInfo[3]);

            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckFuelConsuption = double.Parse(truckInfo[2]);   
            var truckTankCapacity = double.Parse(truckInfo[3]);

            var busFuelQuantity = double.Parse(busInfo[1]);
            var busFuelConsuption = double.Parse(busInfo[2]);
            var busTankCapacity = double.Parse(busInfo[3]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsuption,carTankCapacity);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsuption,truckTankCapacity);
            Vehicle bus = new Bus(busFuelQuantity,busFuelConsuption,busTankCapacity);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {

                var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var action = inputLine[0];
                    var vehicle = inputLine[1];

                    if (action == "Drive")
                    {
                        if (vehicle == "Car")
                        {
                            Console.WriteLine(car.TryTravel(double.Parse(inputLine[2])));
                        }
                        else if (vehicle == "Truck")
                        {
                            Console.WriteLine(truck.TryTravel(double.Parse(inputLine[2])));
                        }
                        else
                        {
                            bus.IsLoaded = true;
                            Console.WriteLine(bus.TryTravel(double.Parse(inputLine[2])));
                        }
                    }
                    else if (action == "Refuel")
                    {
                        if (vehicle == "Car")
                        {
                            car.AddFuel(double.Parse(inputLine[2]));
                        }
                        else if (vehicle == "Bus")
                        {
                            bus.AddFuel(double.Parse(inputLine[2]));
                        }
                        else
                        {
                            truck.AddFuel(double.Parse(inputLine[2]));
                        }
                    }
                    else
                    {
                        bus.IsLoaded = false;
                        Console.WriteLine(bus.TryTravel(double.Parse(inputLine[2])));
                    }
            }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                } 
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

}



