using System;

public class Client
{
    static void Main()
    {
        Vehicle vehicle = new Car();
        vehicle.RunTemplate();
        Console.WriteLine();
        vehicle = new Airplane();
        vehicle.RunTemplate();
    }
}
