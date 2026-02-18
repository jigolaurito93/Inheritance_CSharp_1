using System;

namespace Inheritance_CSharp
{
    public class Cat : Animal
    {
        // Override the Speak method from the Animal class by using the override keyword. This allows the Cat class to provide its own implementation of the Speak method.
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }
}