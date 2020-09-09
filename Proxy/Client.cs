using System;

namespace Proxy
{
    public class Client
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var db = new DbConnectionProxy("some dependencies");
            Console.WriteLine(db.Save(input));
        }
    }
}
