using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharpAndOop.Encapsulation
{
    class PersonBuilder
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _eyeColor;
        private int _hairColor;

        public PersonBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _firstName="Sultan";
            _lastName="Mahmud";
            _age=35;
            _eyeColor=153;
            _hairColor=153;
        }

        public PersonBuilder WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public PersonBuilder WithLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public PersonBuilder WithAge(int age)
        {
            _age = age;
            return this;
        }

        public PersonBuilder WithEyeColor(int eyeColor)
        {
            _eyeColor = eyeColor;
            return this;
        }

        public PersonBuilder WithHairColor(int hairColor)
        {
            _hairColor = hairColor;
            return this;
        }

        public PersonEncap Build()
        {
            PersonEncap personEncap = new PersonEncap(_firstName,_lastName,_age,_eyeColor,_hairColor);

            return personEncap;
        }
    }
}
