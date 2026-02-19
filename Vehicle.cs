using System;

namespace Inheritance_CSharp
{
    // Abstract Class: A class that cannot be instantiated and is typically used as a base class for other classes. It can contain abstract methods (methods without implementation) that must be implemented by derived classes.
    public abstract class Vehicle
    {
        // Abstract method: A method that is declared without an implementation. Derived classes must provide an implementation for this method.
        public abstract void Start();

        // Non-abstract method: A method that has an implementation. Derived classes can use this method as is or override it if needed.
        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping...");
        }
    }
}