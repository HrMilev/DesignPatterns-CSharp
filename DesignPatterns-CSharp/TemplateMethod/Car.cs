using System;

public class Car : Vehicle
{
    protected override void GetIn()
    {
        Console.WriteLine("Get the key and open the door. Sit in the car.");
    }

    protected override void GoGoGo()
    {
        Console.WriteLine("5, 4, 3, 2, 1 ... go go go!!!");
    }

    protected override void StartTheEngine()
    {
        Console.WriteLine("Put the key in the hole ... start the car ...");
    }
}
