// WAP to show the usage of of this keyword.
using System;

namespace ThisKeywordExample
{
    class Program
    {
        class Person
        {
            // Instance variables
            private string name;
            private int age;

            // Constructor
            public Person(string name, int age)
            {
                // Using 'this' keyword to refer to the current instance's variables
                this.name = name;
                this.age = age;
            }

            // Method to display person details
            public void Display()
            {
                // Using 'this' keyword to refer to the current instance's properties
                Console.WriteLine($"Name: {this.name}, Age: {this.age}");
            }
        }

        static void Main(string[] args)
        {
            // Creating an object of Person class
            Person person1 = new Person("John", 30);
            
            // Calling the Display method to show the details
            person1.Display();

            // Creating another object with different values
            Person person2 = new Person("Alice", 25);
            person2.Display();
        }
    }
}
