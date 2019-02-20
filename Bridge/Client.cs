using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Client
{
    static void Main()
    {
        Abstraction abstractBridge = new Abstraction(new ImpA());
        Console.WriteLine(abstractBridge.Operation());
        abstractBridge = new Abstraction(new ImpB());
        Console.WriteLine(abstractBridge.Operation());

    }
}
