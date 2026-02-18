using System;
namespace Inheritance_CSharp
{
    // Class Dog inherits the members of the Animal class
    // Derived Class(Child Class or Subclass)
    public class Dog : Animal
    {
        public Dog()
        {
            Bark();
            Eat();
        }
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }

        public void AccessFields()
        {
            publicField = "Accessing public field coming from Animal class.";
            // This will cause an error because privateField is not accessible in the Dog class
            //privateField = "Accessing private field coming from Animal class."; 
            protectedField = "Accessing protected field coming from Animal class.";
            internalField = "Accessing internal field coming from Animal class.";
        }
    }
}