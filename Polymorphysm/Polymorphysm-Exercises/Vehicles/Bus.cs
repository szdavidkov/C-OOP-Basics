
public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsuption,double tankCapacity)
        :base(fuelQuantity,fuelConsuption,tankCapacity)
    {
    }

    public override string TryTravel(double kilometers)
    {
        var requiredFuel = 0.0;
        if (base.IsLoaded)
        {
            requiredFuel = kilometers * this.FuelConsumption + kilometers * BusFuelIncreaseIfLoaded;
        }
        else
        {
            requiredFuel = kilometers * this.FuelConsumption;
        }
        if (this.FuelQuantity - requiredFuel > 0)
        {
            this.FuelQuantity -= requiredFuel;
            return $"Bus travelled {kilometers} km";
        }

        return $"Bus needs refueling";
    }
}
