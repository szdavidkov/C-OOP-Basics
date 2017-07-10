
using System;

public class Truck :  Vehicle
{
    public Truck(double fuelQuantity, double fuelConsuption,double tankCapacity)
        :base(fuelQuantity,fuelConsuption,tankCapacity)
    {
    }

    public override void AddFuel(double fuelToAdd)
    {
        if (fuelToAdd <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        base.FuelQuantity = base.FuelQuantity + fuelToAdd * 0.95;
    }

    public override string TryTravel(double kilometers)
    {
        var requiredFuel = 0.0;
        if (base.IsLoaded)
        {
            requiredFuel = kilometers * this.FuelConsumption + kilometers * TruckFuelIncreaseInSummer;
        }
        else
        {
            requiredFuel = kilometers * this.FuelConsumption;
        }
        if (this.FuelQuantity - requiredFuel > 0)
        {
            this.FuelQuantity -= requiredFuel;
            return $"Truck travelled {kilometers} km";
        }

        return $"Truck needs refueling";
    }
}
