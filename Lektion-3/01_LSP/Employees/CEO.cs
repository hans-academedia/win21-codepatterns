using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LSP.Employees
{
    internal class CEO : Employee
    {
        public override int HourlySalary { get; set; } = 350;

        public void ReviewEmployee(Employee employee)
        {
            Console.WriteLine($"{FirstName} {LastName} utvärderar {employee.FirstName} {employee.LastName}");
        }

        public void SignDocument(int id)
        {
            Console.WriteLine($"{FirstName} {LastName} skrivet under avtalet: {id}");
        }
    }
}
