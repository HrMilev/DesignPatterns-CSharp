using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        var factory = new CarFactory();
        ICar car = factory.GetCar("blue");
        car.Show("Ferrari");
        Console.WriteLine();
        car = factory.GetCar("blue");
        car.Show("Porsha");
    }
}
