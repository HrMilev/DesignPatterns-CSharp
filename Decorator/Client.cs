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
            View("O ", o);
            TheDecoratorA a = new TheDecoratorA(o);
            View("H ", a);
            TheDecoratorB b = new TheDecoratorB(o);
            View("U ", b);
            TheDecoratorB ba = new TheDecoratorB(a);
            View("P ", ba);
            View(ba.addedState+ba.AddedBehavior(),ba );

        }
    }
}
