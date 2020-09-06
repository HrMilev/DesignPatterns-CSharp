using System;

namespace Prototype
{
    class Client
    {
        static void Main(string[] args)
        {
            var obj = new SomeClass(Console.ReadLine());

            var obj2 = obj.Clone();

            Console.WriteLine("Are reference equal: " + obj.Equals(obj2));
            Console.WriteLine("Are prop equal: " + (obj.Prop == obj2.Prop).ToString());
        }
    }
}
