using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.ValueVSReference
{
    class ReferenceExample
    {
        public ReferenceExample()
        {
            //Reference Type
            PersonRef personRef = new PersonRef();
            personRef.FirstName = "Safwan";
            personRef.LastName = "Mahmud";

            ChangeNameForReferenceType(personRef);
            Console.WriteLine(personRef.FirstName);
            Console.WriteLine(personRef.LastName);

            //Value Type
            PersonValue personValue = new PersonValue();
            personValue.FirstName = "Safwan";
            personValue.LastName = "Mahmud";

            ChangeNameForValueType(personValue);
            Console.WriteLine(personValue.FirstName);
            Console.WriteLine(personValue.LastName);
        }

        private void ChangeNameForReferenceType(PersonRef personToChange)
        {
            personToChange.FirstName="Sultan";
            personToChange.LastName = "Mahmud";
        }

        private void ChangeNameForValueType(PersonValue personToChange)
        {
            personToChange.FirstName = "Sultan";
            personToChange.LastName = "Mahmud";
        }
    }
}
