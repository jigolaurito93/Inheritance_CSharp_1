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

            //  Cannot create an instance of the abstract type of Vehicle class because it is abstract and cannot be instantiated directly. 
            // Abstract classes are meant to be inherited by other classes, and they often contain abstract methods that must be implemented by derived classes.
            //Vehicle vehicle = new Vehicle();
            Car car = new Car();
            car.Start(); //Output: Car is starting...
            car.Stop(); //Output: Vehicle is stopping...

            // Creating an instance of the Employee class and calling the DisplayInfo() method to display the person's information.
            Employee john = new Employee("John Doe", 30, "Software Engineer", 80000);
            john.DisplayEmployeeInfo();

            Department jessie = new Department("Jessie Smith", 28, "Project Manager", 90000, "IT", 101);
            Department jenny = new Department("Jenny Brown", 35, "IT Director", 85000, "IT", 102);  
            Console.WriteLine("Department Size: " + Department.DepartmentSize);
        }
    }
}