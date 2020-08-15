using System;

namespace AbstractFactory
{
    public class Client
    {
        public static void Main()
        {
            FactoryEnum selectedFactory = (FactoryEnum)Enum.Parse(typeof(FactoryEnum), Console.ReadLine());
            IVehicleFactory factory = GetFactory(selectedFactory);
            ICar car = factory.GetCar();
            Console.WriteLine(car.Type());
            ITruck truck = factory.GetTruck();
            Console.WriteLine(truck.Type());
        }

        private static IVehicleFactory GetFactory(FactoryEnum selectedFactory) => 
            selectedFactory switch
            {
                FactoryEnum.Alset => new AlsetFactory(),
                FactoryEnum.WMB => new WMBFactory(),
                _ => throw new ArgumentOutOfRangeException(),
            };
    }
}
