using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.Interface
{
    class Lambargoni : ICar
    {
        private bool _on;

        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "The Lambargoni is on!" : "The Lambargoni is off!");
        }

        public void Drive()
        {
            if (_on)
            {
                Console.WriteLine("Drive Lambargoni");
            }
            else
            {
                Console.WriteLine("Have to start Lambargoni first");
            }
        }
    }
}
