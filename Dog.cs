using System;
namespace Inheritance_CSharp
{
    // Class Dog inherits the members of the Animal class
    // Derived Class(Child Class or Subclass)
    public class Dog : Animal
    {
        // Constructor of the Dog class, which is called when a new instance of the Dog class is created. It calls the Eat() method and the Speak() method inherited from the Animal class.
        public Dog()
        {
            Eat();
            // When the Speak() method is called on a Dog instance, it will call the overridden Speak() method in the Dog class, which outputs "Woof!" instead of the default implementation in the Animal class.
            Speak();
        }
        public override void Speak()
        {
            base.Speak(); // This will call the Speak() method of the base class (Animal) before executing the Dog's Speak() method.
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