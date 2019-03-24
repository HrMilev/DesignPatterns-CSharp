using System;
using System.Collections.Generic;
using System.Linq;

public class CarDealership
{
    private List<ICar> cars;

    public CarDealership()
    {
        cars = new List<ICar>();
    }

    public void AddCar(ICar car)
    {
        cars.Add(car);
    }

    public void GetSalesmen(ISalesmen salesmen)
    {
        foreach (var car in cars)
        {
            car.AcceptSalesmen(salesmen);
        }
    }

    public override string ToString()
    {
        return String.Join(Environment.NewLine, cars.Select(x =>"Price for "+ x.ToString() + " is " + x.Price)); 
    }
}
