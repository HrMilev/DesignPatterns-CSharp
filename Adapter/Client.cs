using System;

namespace Adapter
{
    public class Client
    {
        public static void Main()
        {
            var fileAdapter = new FileAdapter();
            Console.WriteLine(fileAdapter.ReadFromFile("../../../README.md"));
        }
    }
}
