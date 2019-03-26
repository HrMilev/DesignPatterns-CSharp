using System;
using System.Collections.Generic;

public class CarFactory
{
    Dictionary<string, ICar> cars;

    public CarFactory()
    {
        cars = new Dictionary<string, ICar>();
    }

    public ICar GetCar(string color)
    {
        if (cars.ContainsKey(color))
        {
            Console.WriteLine($"I am a old {color} car!");
            return cars[color];
        }
        else
        {
            ICar car = new Car(color);
            cars.Add(color, car);
            return car;
        }
    }
}
