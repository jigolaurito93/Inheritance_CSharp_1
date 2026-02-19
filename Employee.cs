using System;
namespace Inheritance_CSharp
{
    // Employee class inherits from the Person class, which means it can access the properties and methods of the Person class.
    public class Employee : Person
    {
        // Properties specific to the Employee class, with private setters to allow read-only access from outside the class.
        public string JobPosition { get; private set; }
        public int Salary { get; private set; }
        // Constructor of the Employee class, which takes parameters for the name, age, job position, and salary. 
        // It calls the base class constructor using the base keyword to initialize the Name and Age properties inherited 
        // from the Person class, and then initializes the JobPosition and Salary properties specific to the Employee class.
        public Employee(string name, int age, string jobPosition, int salary) : base(name, age)
        {
            JobPosition = jobPosition;
            Salary = salary;
            Console.WriteLine("Employee constructor called");
            Console.WriteLine($"Employee created: {Name}, Age: {Age}, Job: {JobPosition}, Salary: {Salary} in the Employee class.");
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("DisplayEmployeeInfo method called.");
            // Display the JobPosition and Salary properties specific to the Employee class.
            Console.WriteLine("Job Position: " + JobPosition);
            Console.WriteLine("Salary: $" + Salary);
        }
    }
}