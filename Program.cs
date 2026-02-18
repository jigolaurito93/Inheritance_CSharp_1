using System;
namespace Inheritance_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Dog instance from the Dog class, which inherits from the Animal class.
            // When the Dog instance is created, it will call the constructor of the Dog class, 
            // which in turn calls the Bark() method and the Eat() method inherited from the Animal class.
            Dog chihuahua = new Dog();
            
            // Create a Cat instance from the Cat class, which inherits from the Animal class.
            // When using the method Speak() on the Cat instance, it will call the overridden Speak() method in the Cat class, which outputs "Meow!" instead of the default implementation in the Animal class.
            Cat siamese = new Cat();
            siamese.Speak();
        }
    }
}