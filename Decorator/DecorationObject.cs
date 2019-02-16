using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecorationObject : IDecorationObject
    {
        public string Operation() => "I am for decorating ...";
    }
}
