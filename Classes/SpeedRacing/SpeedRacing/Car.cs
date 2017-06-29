using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelFor1Kilometer;
    private int distanceTravelled;

    public Car(string model, int fuelAmount, double fuelFor1Kilometer)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelFor1Kilometer = fuelFor1Kilometer;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public double FuelFor1Kilometer
    {
        get { return this.fuelFor1Kilometer; }
        set { this.fuelFor1Kilometer = value; }
    }

    public int DistanceTravelled
    {
        get { return this.distanceTravelled; }
        set { this.distanceTravelled = value; }
    }


    public void Drive(int distance)
    {
        var neededFuel = this.fuelFor1Kilometer * distance;

        if (neededFuel >fuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.DistanceTravelled += distance;
            this.FuelAmount -= neededFuel;
        }
    }
}

