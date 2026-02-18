using System;

namespace Inheritance_CSharp
{
    // Base Class (Parent Class or Superclass): The class whose members are inherited
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        // Protected means that the member is accessible within its class and by derived class instances
        // Private means that the member is accessible only within its class
        // Internal means that the member is accessible only within files in the same assembly
        // Public means that the member is accessible from any other code
    }
}