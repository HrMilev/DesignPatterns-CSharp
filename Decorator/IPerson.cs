using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string HowAmI();
    }
}
