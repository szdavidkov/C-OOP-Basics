
using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity , double fuelConsuption,double tankCapacity)
        :base(fuelQuantity,fuelConsuption,tankCapacity)
    {
    }


    public override string TryTravel(double kilometers)
    {
        var requiredFuel = 0.0;
        if (base.IsLoaded)
        {
            requiredFuel = kilometers * this.FuelConsumption + kilometers * CarFuelIncreaseInSummer;
        }
        else
        {
            requiredFuel = kilometers * this.FuelConsumption;
        }
        if (this.FuelQuantity - requiredFuel > 0)
        {
            this.FuelQuantity -= requiredFuel;
            return $"Car travelled {kilometers} km";
        }

        return $"Car needs refueling";
    }
}
