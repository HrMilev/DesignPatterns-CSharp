using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        CarDealership carDealership = new CarDealership();
        carDealership.AddCar(new Ferrari { Price = 500 });
        carDealership.AddCar(new Jaguar { Price = 1000 });

        Console.WriteLine(carDealership.ToString());
        Console.WriteLine();
        Salesman salesman = new Salesman(55);
        Console.WriteLine("New:");
        carDealership.GetSalesmen(salesman);
        Console.WriteLine(carDealership.ToString());
        Console.WriteLine();
        Console.WriteLine(salesman.CountOfCars());
    }
}
