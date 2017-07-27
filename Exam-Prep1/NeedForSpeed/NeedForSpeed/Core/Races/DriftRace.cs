using System.Collections.Generic;

public class DriftRace : Race
{
    public DriftRace(int lenght, string route, int prizePool) : base(lenght, route, prizePool)
    {
    }

    public override int GetPerformance(int id)
    {
        var car = Participants[id];
        return (car.Suspension + car.Durability);
    }
}
