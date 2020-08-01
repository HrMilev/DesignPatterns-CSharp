using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Manager : IEmployee
    {
        private readonly IPerson person;

        public Manager(IPerson person)
        {
            this.person = person;
        }

        public string WorkPlace { get; set; }
        public string FirstName { get => person.FirstName; set => person.FirstName = value; }
        public string LastName { get => person.LastName; set => person.LastName = value; }

        public string HowAmI()
        {
            return person.HowAmI() + $" and finally i am a manager";
        }
    }
}
