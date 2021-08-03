using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.Interface
{
    class PersonInterface
    {
        private ICar _car;

        public PersonInterface(ICar car)
        {
            _car = car;
        }

        public void Drive()
        {
            _car.TurnOnOff();
            _car.Drive();
        }
    }
}
