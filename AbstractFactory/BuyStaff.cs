using System;

partial class Program
{
    public class BuyStaff<Brand> where Brand : IBrand, new()
    {
        public void Now()
        {
            IFactory<Brand> factory = new Factory<Brand>();
            ITelevision tv = factory.CreateTV();
            IRefrigerator frige = factory.CreateRefrigerator();

            Console.WriteLine("I have nice new tv with wide " + tv.Display + " display");
            Console.WriteLine("And i also have cheap " + frige.Price + " money refrigerator");
        }
    }
}
