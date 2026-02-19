using System;

namespace Inheritance_CSharp
{
    public class Person
    {
        // Properties with private setters to encapsulate the fields and allow read-only access from outside the class. 
        // The values can only be set within the constructor of the Person class.
        public string Name { get; private set; }
        public int Age { get; private set; }

        // Constructor of the Person class, which is called when a new instance of the Person class is created. 
        // It initializes the Name and Age properties with the values passed as parameters.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Person created: {Name}, Age: {Age} in the Person class.");

        }
        // Method to display the information of the person. It prints the Name and Age properties to the console.
        public void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo method called.");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

    }
}