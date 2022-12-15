using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LSP.Interfaces
{
    internal interface IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HourlySalary { get; set; }

        public void GetMonthlySalary();
        public void GetYearlySalary();
    }
}
