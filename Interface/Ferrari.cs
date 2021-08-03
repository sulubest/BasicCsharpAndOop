using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.Interface
{
    class Ferrari : ICar
    {
        private bool _on;

        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "The Ferrari is on!" : "The Ferrari is off!");
        }

        public void Drive()
        {
            if (_on)
            {
                Console.WriteLine("Drive Ferrari");
            }
            else
            {
                Console.WriteLine("Have to start Ferrari first");
            }
        }
    }
}
