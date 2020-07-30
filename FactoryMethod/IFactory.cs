using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IFactory
    {
        IBakedGood GetSomeGood();
    }
}
