using System;

namespace Inheritance_CSharp
{
    // Base Class (Parent Class or Superclass): The class whose members are inherited
    public class Animal
    {
        // Public fields can be accessed from anywhere, including derived classes and other classes
        public string publicField = "This is a public field.";
        // Private fields can only be accessed within the class they are declared in, and cannot be accessed from derived classes or other classes
        private string privateField = "This is a private field.";
        // Protected fields can be accessed within the class they are declared in and by derived classes, but not from other classes
        protected string protectedField = "This is a protected field.";
        // Internal fields can be accessed from any class within the same assembly, but not from classes in other assemblies
        internal string internalField = "This is an internal field.";
        
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        // Protected means that the member is accessible within its class and by derived class instances
        // Private means that the member is accessible only within its class
        // Internal means that the member is accessible only within files in the same assembly
        // Public means that the member is accessible from any other code

        // Virtual method allows derived classes to override it with their own implementation
        // If a method is marked as virtual, it can be overridden in a derived class using the override keyword.
        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking generically...");
        }
    }
}