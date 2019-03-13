using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        var builder = new Builder();

        builder.BuildSteelHouse();
        builder.BuildTimberHouse();
    }
}
