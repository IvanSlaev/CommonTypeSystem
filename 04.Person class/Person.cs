using System;

namespace _04.Person_class
{
    public class Person
    {
        private string _name;
        private int? _age;

        public Person(string name, int? age = null)
        {
            this._name = name;
            this.Age = age;
        }

        public string Name => _name;

        public int? Age
        {
            get { return this._age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Come on you are 121 years old or even above, you are kidding me maaaan");
                }
                this._age = value;
            }
        }


        public override string ToString()
        {
            if (Age == null)
            {
                return $"My name is {Name}, unfortunately my age is not specified!";
            }
            return $"My name is {Name}, and I am {Age}.";
        }
    }
}
