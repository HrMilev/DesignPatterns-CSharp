using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Car();
        vehicle.RunTemplate();
        Console.WriteLine();
        vehicle = new Airplane();
        vehicle.RunTemplate();
    }
}
