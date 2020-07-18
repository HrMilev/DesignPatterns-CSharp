using System;

public class Normal : IHeating
{
    public int Limit { get => 60; }

    IHeating heating = new Hot();

    public void GetStatus(int temp)
    {
        Console.WriteLine($"Increase with {Limit-temp} degrees to {heating.GetType().Name}");
    }
}
