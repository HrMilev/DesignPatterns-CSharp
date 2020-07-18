using System;

public class Car : ICar
{
    private string color; //intrinsic

    public Car(string color)
    {
        Console.WriteLine($"I am a new {color} car!");
        this.color = color;
    }

    public void Show(string brand)//extrinsic
    {
        Console.WriteLine($"I like this {color} {brand}");
    }
}
