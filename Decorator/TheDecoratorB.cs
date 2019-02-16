using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class TheDecoratorB : IDecorationObject
    {
        IDecorationObject theObject;
        public string addedState = "in Blue :)";

        public TheDecoratorB(IDecorationObject it) => this.theObject = it;

        public string Operation()
        {
            string s = theObject.Operation();
            return s += "Second time decorated ...";
        }

        public string AddedBehavior() => "... i hate blue ...";
    }
}
