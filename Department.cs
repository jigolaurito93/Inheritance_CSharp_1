using System;
namespace Inheritance_CSharp
{
    public class Department : Employee
    {
        public string DepartmentName { get; private set; }
        public int DepartmentCode { get; private set; }
        public static int DepartmentSize { get; private set; }

        public Department(string name, int age, string jobPosition, int salary, string departmentName, int departmentCode) : base(name, age, jobPosition, salary)
        {
            DepartmentName = "IT";
            DepartmentCode = departmentCode;
            DepartmentSize++;
            Console.WriteLine("Department constructor called");
        }
    }
}