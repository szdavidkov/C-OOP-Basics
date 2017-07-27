using System.Collections.Generic;

public class CasualRace : Race
{
    public CasualRace(int lenght, string route, int prizePool) : base(lenght, route, prizePool)
    {
    }

    public override int GetPerformance(int id)
    {
        var car = Participants[id];
        return (car.HorsePower / car.Acceleration) + (car.Suspension + car.Durability);
        
    }
}
