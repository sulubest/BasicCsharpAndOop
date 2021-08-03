using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.Inheritance
{
    class PersonInheritance
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PersonInheritance(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void Walk()
        {
            Console.WriteLine("I am walking");
        }

        public void Eat()
        {
            Console.WriteLine("I am eating");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping");
        }
    }
}
