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
        /// <summary>
        /// Method to increase the age of the person by a specified number of years. 
        /// It takes an integer parameter representing the number of years to add to the current age, 
        /// updates the Age property, and returns the new age. It also prints a message to the console 
        /// indicating how many years the person has become older and what their new age is.
        /// </summary>
        /// <param name="years"></param>
        /// <returns>Returns the new age after aging/becoming older</returns>
        public int BecomeOlder(int years)
        {
            Age += years;
            Console.WriteLine($"{Name} has become older by {years} years. New age: {Age}");
            return Age;
        }

    }
}