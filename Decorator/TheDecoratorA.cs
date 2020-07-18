using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class TheDecoratorA : IDecorationObject
    {
        IDecorationObject theObject;

        public TheDecoratorA(IDecorationObject it) => this.theObject = it;

        public string Operation()
        {
            string s = theObject.Operation();
            return s += "... and i was decorated !!!";
        }
    }
}
