using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        Console.Write("Input your magic number:");
        DummyCalculator dummy = new DummyCalculator(double.Parse(Console.ReadLine()));
        Console.Write("Input your enchanting operation symbol:");
        string operation = Console.ReadLine();
        while (!operation.Equals("="))
        {
            switch (operation)
            {
                case "*":
                    dummy.ChooseOperation(new Multiply(dummy.InternalNumber));
                    break;
                case "/":
                    dummy.ChooseOperation(new Divide(dummy.InternalNumber));
                    break;
                default:
                    Console.WriteLine("Invalid input, please try harder:");
                    operation = Console.ReadLine();
                    continue;
            }
            Console.Write("Input your next number:");
            dummy.By(double.Parse(Console.ReadLine()));
            Console.Write("Input your enchanting operation symbol:");
            operation = Console.ReadLine();
        }
        Console.WriteLine();
        Console.WriteLine("Voalaaa: " + dummy.InternalNumber);
    }
}
