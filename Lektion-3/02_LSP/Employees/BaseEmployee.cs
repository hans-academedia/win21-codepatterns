using _02_LSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LSP.Employees
{
    internal abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int HourlySalary { get; set; }

        public virtual void GetMonthlySalary()
        {
            Console.WriteLine($"{FirstName} {LastName} har {(HourlySalary * 167).ToString("N")} i månadslön.");
        }

        public virtual void GetYearlySalary()
        {
            Console.WriteLine($"{FirstName} {LastName} har {((HourlySalary * 167) * 12).ToString("N")} i årslön.");
        }
    }
}
