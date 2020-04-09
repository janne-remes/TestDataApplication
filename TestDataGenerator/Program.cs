using Microsoft.VisualBasic;
using System;

namespace TestDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person dudeOne = new Person("Pekka", "Paavola", 54);

            Console.WriteLine($"{dudeOne.firstName} {dudeOne.lastName}, {dudeOne.age} vuotta");

        }
    }
}
