using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    interface IHuman
    {
        string Name { get; }
    }

    class Person : IHuman
    {
        public int age;
        public string Name
        { get; }
        public string jobTitle;

        public Person(string name, string jobTitle, int age = 0)
        {
            this.age = age;
            this.Name = name;
            this.jobTitle = jobTitle;
        }

        private void addOneYear()
        {
            this.age++;
        }

        public void singHappyBirthday()
        {
            addOneYear();
        }

        public string introduce()
        {
            return $"Hello my name is {this.Name}. I am currently a {this.jobTitle}, and I am {this.age} years old.";
        }
    }
}
