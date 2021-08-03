using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.NullCoalescing
{
    class CoalescingEample
    {
        public CoalescingEample()
        {
            PersonCoalescing personCoalescing = null;

            PersonCoalescing newPersonCoalescing = personCoalescing ?? new PersonCoalescing("Default", "Person");

            Console.WriteLine(newPersonCoalescing.FirstName);
        }

    }
}
