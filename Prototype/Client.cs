using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        var factory = new CarFactory();
        Prototype<Car> c2;

        Console.WriteLine(factory.Cars[0].ToString());

        c2 = factory.Cars[0].DeepClone();
        ((Car)c2).Engine.Type = "Benzin";
        ((Car)c2).Color = "Green";
        Console.WriteLine(c2.ToString());
        Console.WriteLine(factory.Cars[0].ToString());

    }
}
