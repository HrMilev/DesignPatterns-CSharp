using System;

namespace Facade
{
    public class Client
    {
        //It’s especially useful when working with complex libraries and APIs
        static void Main()
        {
            var pan = new Pan();
            var stove = new Stove(pan);
            var chicken = new Chicken();
            ICookingFacade facade = new CookingFacade(stove, pan, chicken);

            Console.WriteLine(facade.GetChickenOnStove());
        }
    }
}
