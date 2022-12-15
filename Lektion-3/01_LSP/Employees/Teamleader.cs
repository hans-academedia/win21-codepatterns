using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LSP.Employees
{
    internal class Teamleader : Employee
    {
        public override int HourlySalary { get; set; } = 250;

        public void ReviewEmployee(Employee employee)
        {
            Console.WriteLine($"{FirstName} {LastName} utvärderar {employee.FirstName} {employee.LastName}");
        }
    }
}
