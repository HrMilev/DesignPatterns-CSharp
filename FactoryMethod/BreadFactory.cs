using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class BreadFactory : IFactory
    {
        public IBakedGood GetSomeGood()
        {
            return new Bread();
        }
    }
}
