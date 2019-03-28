using System;

public class Boil : IHeating
{
    public int Limit { get => 1000; }

    IHeating heating = null;

    public void GetStatus(int temp)
    {
        Console.WriteLine($"Its boiling ...");
    }
}
