using System;
namespace Inheritance_CSharp
{
    // Concrete class that inherits from the abstract class Vehicle. 
    // Since Vehicle has an abstract method Start(), Car must provide an implementation for this method.
    class Car : Vehicle
    {
        // Providing an implementation for the abstract method Start() from the Vehicle class. 
        // This is required because Car is a non-abstract class that inherits from an abstract class (Vehicle).
        public override void Start()
        {
            Console.WriteLine("Car is starting...");
        }
    }
}