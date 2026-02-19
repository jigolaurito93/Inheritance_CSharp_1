using System;
namespace Inheritance_CSharp
{
    public class Employee : Person
    {
        public Employee(string name, int age) : base(name, age)
        {
            Console.WriteLine("Employee constructor called");
            Console.WriteLine($"Employee created: {Name}, Age: {Age} in the Employee class.");
        }
    }
}