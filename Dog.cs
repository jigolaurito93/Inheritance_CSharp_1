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
    }
}