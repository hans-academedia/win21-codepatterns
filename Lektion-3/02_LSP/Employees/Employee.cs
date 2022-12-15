using _02_LSP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LSP.Employees
{
    internal class Employee : BaseEmployee, IHasManager
    {
        public IEmployee Manager { get; set; } = null!;

        public void ShowManager()
        {
            Console.WriteLine($"{FirstName} {LastName} har {Manager.FirstName} {Manager.LastName} som sin närmaste chef.");
        }
    }
}

