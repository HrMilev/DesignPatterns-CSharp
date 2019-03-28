using System;
using System.Collections.Generic;
using System.Linq;

public class Water
{
    int internalTemp;
    IHeating currentState;
    List<IHeating> heating;

    public Water(List<IHeating> heating)
    {
        this.heating = heating;
        Console.WriteLine("You put the water on the stove.");
    }

    public void CurrentState()
    {
        Console.WriteLine($"Internal temperature is: {internalTemp}");
        currentState.GetStatus(internalTemp);
        Console.WriteLine();
    }

    public void AddTemp(int temp)
    {
        internalTemp += temp;
        Console.WriteLine($"Increase temperature with {temp}");
        var heat = heating.Where(x => x.Limit >= internalTemp).Aggregate((x1,x2) =>x1.Limit<x2.Limit ? x1 : x2);
        Console.WriteLine($"The state is {heat.GetType().Name}");
        currentState = heat;
        Console.WriteLine();
    }

    public void RemoveTemp(int temp)
    {
        internalTemp -= temp;
        Console.WriteLine($"Decrease temperature with {temp}");
        var heat = heating.Where(x => x.Limit >= internalTemp).Aggregate((x1, x2) => x1.Limit < x2.Limit ? x1 : x2);
        Console.WriteLine($"The state is {heat.GetType().Name}");
        currentState = heat;
        Console.WriteLine();
    }
}
