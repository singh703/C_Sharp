using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance1
{
    internal class Program
    {
        public class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }

            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("Employee name: {0}", Name);
                Console.WriteLine("Employee age: {0}", Age);
                Console.WriteLine("Employee salary: {0:n}", Salary);
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Employee employee = new Employee();
                employee.Name = "John Doe";
                employee.Age = 30;
                employee.Salary = 50000;

                employee.DisplayEmployeeDetails();
            }
        }
    }
}
