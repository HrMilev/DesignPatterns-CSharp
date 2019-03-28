using System;

public class Hot : IHeating
{
    public int Limit { get => 100; }

    IHeating heating = new Boil();

    public void GetStatus(int temp)
    {
        Console.WriteLine($"Increase with {Limit - temp} degrees to {heating.GetType().Name}");
    }
}
