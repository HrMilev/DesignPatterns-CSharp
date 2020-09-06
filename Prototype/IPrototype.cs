using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IPrototype<T> where T : class
    {
        T Clone();
    }
}
