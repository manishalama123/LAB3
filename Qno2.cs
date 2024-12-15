using System;
using System.Collections.Generic;
using System.Linq;

namespace Q2_EmployeeLINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
         
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Manisha", Salary = 60000, Address = "Kathmandu" },
                new Employee { Id = 2, Name = "Mamata", Salary = 45000, Address = "Pokhara" },
                new Employee { Id = 3, Name = "Alina", Salary = 32000, Address = "Kathmandu" },
                new Employee { Id = 4, Name = "Mira", Salary = 70000, Address = "Bhaktapur" },
                new Employee { Id = 5, Name = "Sophia", Salary = 55000, Address = "Kathmandu" }
               
            };

            // LINQ query to select employees with Salary > 50000 and Address = "Kathmandu"
            var highPaidEmployeesInKathmandu = employees
                .Where(e => e.Salary > 50000 && e.Address == "Kathmandu")
                .ToList();

            // Display the results
            Console.WriteLine("Employees with salary greater than 50,000 and address in Kathmandu:");
            foreach (var employee in highPaidEmployeesInKathmandu)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}, Address: {employee.Address}");
            }
            Console.ReadKey();
        }*/
    }
}
