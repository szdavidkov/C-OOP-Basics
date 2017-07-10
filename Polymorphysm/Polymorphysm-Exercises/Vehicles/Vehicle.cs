
using System;

public abstract class Vehicle
{

    protected const double CarFuelIncreaseInSummer = 0.9;
    protected const double TruckFuelIncreaseInSummer = 1.6;
    protected const double BusFuelIncreaseIfLoaded = 1.4;

    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;
    private bool isLoaded;

    protected Vehicle(double fuelQuantity,double fuelConsuption,double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsuption;
        this.TankCapacity = tankCapacity;
        this.IsLoaded = false;
    }

    public bool IsLoaded
    {
        get { return this.isLoaded; }
        set { this.isLoaded = value; }
    }


    public double TankCapacity
    {
        get { return this.tankCapacity; }
        set { this.tankCapacity = value; }
    }

    public virtual double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set
        {
            this.fuelQuantity = value;
        }
    }
    public virtual double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }
    public virtual void AddFuel(double fuelToAdd)
    {
        if (fuelToAdd <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if (fuelToAdd + this.FuelQuantity > this.TankCapacity)
        {
            throw new ArgumentException("Cannot fit fuel in tank");
        }

        this.FuelQuantity = this.fuelQuantity + fuelToAdd;
    }

    public abstract string TryTravel(double kilometers);
}



