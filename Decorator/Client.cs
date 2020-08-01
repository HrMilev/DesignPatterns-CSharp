using System;

namespace Decorator
{
    public class Client
    {
        public static void Main()
        {
            IPerson person = new Person { FirstName = "working", LastName = "hard" };
            Console.WriteLine(person.HowAmI());

            Console.WriteLine("And i just get a new exciting job ...");
            person = new Employee(person) { WorkPlace = "Fancy Co." };
            Console.WriteLine(person.HowAmI());

            Console.WriteLine("And after few years ...");
            person = new Manager(person);
            Console.WriteLine(person.HowAmI());
        }
    }
}
