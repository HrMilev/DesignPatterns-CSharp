using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{

    static void Main(string[] args)
    {
        new BuyStaff<Philips>().Now();
        Console.WriteLine();
        new BuyStaff<Sharp>().Now();
    }
}
