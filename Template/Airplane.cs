using System;

public class Airplane : Vehicle
{
    protected override void GetIn()
    {
        Console.WriteLine("Get in the plane. Sit in the cockpit");
    }

    protected override void GoGoGo()
    {
        Console.WriteLine("Be like a Jhon trabolta ... fly ...");
    }

    protected override void StartTheEngine()
    {
        Console.WriteLine("I don't know ... start the engine");
    }
}
