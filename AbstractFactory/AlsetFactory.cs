using System;

namespace AbstractFactory
{
    public class AlsetFactory : IVehicleFactory
    {
        public ICar GetCar()
        {
            Console.WriteLine("I am Alset factory and i will create car ...");
            return new AlsetCar();
        }

        public ITruck GetTruck()
        {
            Console.WriteLine("I am Alset factory and i will create truck ...");
            return new AlsetTruck();
        }
    }
}
