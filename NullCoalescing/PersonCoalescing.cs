using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.NullCoalescing
{
    class PersonCoalescing
    {
        public PersonCoalescing(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }
}