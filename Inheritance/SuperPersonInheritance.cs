using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.Inheritance
{
    class SuperPersonInheritance : PersonInheritance
    {
        public SuperPersonInheritance(string FirstName, string LastName) : base (FirstName,LastName)
        {

        }

        public void Fly()
        {
            Console.WriteLine("I am flying");
        }
    }
}
