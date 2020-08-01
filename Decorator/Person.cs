using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string HowAmI()
        {
            return $"I am {FirstName} {LastName}!";
        }
    }
}
