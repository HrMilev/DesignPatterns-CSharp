using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface IEmployee : IPerson
    {
        string WorkPlace { get; set; }
    }
}
