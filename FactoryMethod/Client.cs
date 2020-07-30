using System;

namespace FactoryMethod
{
    public class Client
    {
        public static void Main()
        {
            Console.WriteLine("Pick something: 1 - Bread, 2 - Biscuit");
            int.TryParse(Console.ReadLine(), out int type);

            while (type < 1 || type > 2)
            {
                int.TryParse(Console.ReadLine(), out type);
            }

            IFactory factory = null;

            if (type == 1)
            {
                factory = new BreadFactory();
            }
            else
            {
                Console.WriteLine("Add your secret biscuit ingredient: ");
                string secret = Console.ReadLine();
                factory = new BiscuitFactory(secret);
            }

            IBakedGood bakedGood = factory.GetSomeGood();
            Console.WriteLine(bakedGood.WhatAmI());
        }
    }
}
