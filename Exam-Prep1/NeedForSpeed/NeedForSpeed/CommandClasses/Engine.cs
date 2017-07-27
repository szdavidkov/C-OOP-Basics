using System;



public class Engine
{

    private CarManager manager;


    public Engine()
    {
        this.manager = new CarManager();
    }

    public void Run()
    {
        string command;
        while((command = Console.ReadLine()) != "Cops Are Here")
        {
            var commandArgs = command.Split(' ');
            ExecuteCommmand(commandArgs);
        }
    }

    private void ExecuteCommmand(string[] commandArgs)
    {
        int id;
        string type;

        switch (commandArgs[0])
        {
            
            case "register":
                id = int.Parse(commandArgs[1]);
                type = commandArgs[2];
                string brand = commandArgs[3];
                string model = commandArgs[4];
                int yearOfProduction = int.Parse(commandArgs[5]);
                int horsepower = int.Parse(commandArgs[6]);
                int acceleration = int.Parse(commandArgs[7]);
                int suspension = int.Parse(commandArgs[8]);
                int durability = int.Parse(commandArgs[9]);
                manager.Register(id,type,brand,model,yearOfProduction,horsepower,acceleration,suspension,durability);
                break;
            case "check":
                id = int.Parse(commandArgs[1]);
                Console.WriteLine(manager.Check(id));
                break;
            case "open":
                id = int.Parse(commandArgs[1]);
                type = commandArgs[2];
                int lenght = int.Parse(commandArgs[3]);
                string route = commandArgs[4];
                int prizePool = int.Parse(commandArgs[5]);
                manager.Open(id,type,lenght,route,prizePool);
                break;
            case "participate":
                int carId = int.Parse(commandArgs[1]);
                int raceId = int.Parse(commandArgs[2]);

                manager.Participate(carId,raceId);
                break;
            case "start":
                id = int.Parse(commandArgs[1]);
                Console.WriteLine(manager.Start(id));
                break;
            case "park":
                id = int.Parse(commandArgs[1]);
                manager.Park(id);
                break;
            case "unpark":
                id = int.Parse(commandArgs[1]);
                manager.Unpark(id);
                break;
            case "tune":
                var tuneIndex = int.Parse(commandArgs[1]);
                var addOn = commandArgs[2];
                manager.Tune(tuneIndex,addOn);
                break;
        }
    }
}
