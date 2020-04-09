using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGenerator
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public static List<string> FirstNameMales = new List<string>()
        {
            "Pekka",
            "Arto",
            "Tauno",
            "Mikko",
            "Sakari",
            "Paavo",
            "Risto",
            "Olavi"
        };
    }
}
