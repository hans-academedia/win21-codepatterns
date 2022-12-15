using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DIP.Interfaces
{
    internal interface IPerson
    {
        string DisplayName { get; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string? PhoneNumber { get; set; }
    }
}
