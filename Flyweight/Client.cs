using System;

namespace Flyweight
{
    public class Client
    {
        public static void Main()
        {
            var factory = new BrickFactory();
            var b1 = factory.GetBrick(1);
            var b2 = factory.GetBrick(2);

            Console.WriteLine(b1.Render());
            Console.WriteLine(b2.Render());
            Console.WriteLine(b1.AreEqual(b2));
            Console.WriteLine(b1.ArePicturesEqual(b2));
        }
    }
}
