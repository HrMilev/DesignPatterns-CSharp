using System;

class Excavator
{
    public void Dig()
    {
        Console.WriteLine("Excavator start digging....");
    }
}

class ConcretePump
{
    public void Pump()
    {
        Console.WriteLine("Pumping the foundations ....");
    }
}

class TimberWorker
{
    public void Working()
    {
        Console.WriteLine("Building the timber ...");
    }
}

class SteelWorker
{
    public void Working()
    {
        Console.WriteLine("Building the steel ...");
    }
}


public class Builder
{
    SteelWorker steelWorker = new SteelWorker();
    TimberWorker timberWorker = new TimberWorker();
    ConcretePump concretePump = new ConcretePump();
    Excavator excavator = new Excavator();

    public void BuildTimberHouse()
    {
        Console.WriteLine("Start timbering ");
        excavator.Dig();
        concretePump.Pump();
        timberWorker.Working();
        Console.WriteLine("End building");
        Console.WriteLine();
    }

    public void BuildSteelHouse()
    {
        Console.WriteLine("Start steeling");
        excavator.Dig();
        concretePump.Pump();
        steelWorker.Working();
        Console.WriteLine("End building");
        Console.WriteLine();
    }
}
