using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Client
    {
        static void View(string s, IDecorationObject obj) => Console.WriteLine(s + obj.Operation());

        static void Main(string[] args)
        {
            DecorationObject o = new DecorationObject();
            View("Ohh ", o);
            TheDecoratorA a = new TheDecoratorA(o);
            View("Hehe ", a);
            TheDecoratorB b = new TheDecoratorB(o);
            View("Uraa ", b);
            TheDecoratorB bb = new TheDecoratorB(a);
            View("Pfff ", bb);
            View(bb.addedState+bb.AddedBehavior(),bb );

        }
    }
}
