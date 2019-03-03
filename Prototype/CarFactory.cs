using System.Collections.Generic;

public class CarFactory : Prototype<Car>
{
    public List<Car> Cars = new List<Car>
    {
        new Car { Color = "Red" , Engine = new Engine { Type = "Diesel"}, Type = "Alfa Romeo"},
        new Car { Color = "Blue" , Engine = new Engine { Type = "Diesel"}, Type = "BMW"},
    };
}
