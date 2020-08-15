using System;

namespace AbstractFactory
{
    public class WMBFactory : IVehicleFactory
    {
        public ICar GetCar()
        {
            Console.WriteLine("I am WMB factory and i will create car ...");
            return new WMBCar();
        }

        public ITruck GetTruck()
        {
            Console.WriteLine("I am WMB factory and i will create truck ...");
            return new WMBTruck();
        }
    }
}
