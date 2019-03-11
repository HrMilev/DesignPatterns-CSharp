using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        int story = 5;
        Console.WriteLine("Before:");
        var old = new OldHouse();
        Console.WriteLine(old.With(story));

        Console.WriteLine();

        Console.WriteLine("After:");
        IRenovator ren = new NewOldHouse();
        Console.WriteLine(ren.WithNew(story));
    }
}
