using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        CakeList<string> cakes = new CakeList<string>(3);
        cakes[0] = "vanila";
        cakes[1] = "strawberry";
        cakes[2] = "apple";
        IIterator<string> iterator = cakes.GetIterator();
        while (iterator.IstFinished())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}
