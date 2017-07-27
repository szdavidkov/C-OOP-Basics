using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private NationsBuilder nationsBuilder;
    private bool isRunning;

    public Engine()
    {
        this.nationsBuilder = new NationsBuilder();
        this.isRunning = true;
    }

    public void Run()
    {
        while (this.isRunning)
        {
            var input = Console.ReadLine();
            var inputParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            this.ExecuteCommand(inputParams);
        }
    }

    private void ExecuteCommand(List<string> inputParams)
    {
        var command = inputParams[0];
        switch (command)
        {   
            case "Bender":
                this.nationsBuilder.AssignBender(inputParams);
                break;
            case "Monument":
                this.nationsBuilder.AssignMonument(inputParams);
                break;
            case "Status":
                var status = this.nationsBuilder.GetStatus(inputParams[1]);
                this.OutputWriter(status);
                break;
            case "War":
                this.nationsBuilder.IssueWar(inputParams[1]);
                break;
            case "Quit":
                var record = this.nationsBuilder.GetWarsRecord();
                this.OutputWriter(record);
                this.isRunning = false;
                break;
        }
    }

    private void OutputWriter(string status)
    {
        Console.WriteLine(status);
    }
}

