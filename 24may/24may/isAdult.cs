using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24may
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool isAdult;

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            isAdult = true;
            if (Age > 18)
            {
                Console.WriteLine(isAdult);
            }
            else
            {
                Console.WriteLine(!isAdult);
            }
        }
    }
}
