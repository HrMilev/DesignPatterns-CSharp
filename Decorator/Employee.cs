using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Employee : IEmployee
    {
        private readonly IPerson person;

        public Employee(IPerson person)
        {
            this.person = person;
        }

        public string WorkPlace { get; set; }
        public string FirstName { get => person.FirstName; set => person.FirstName = value; }
        public string LastName { get => person.LastName; set => person.LastName = value; }

        public string HowAmI()
        {
            return person.HowAmI() + $" I work for {WorkPlace}";
        }
    }
}
