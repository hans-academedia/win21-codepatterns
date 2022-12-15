using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SOLID_SRP.Models
{
    internal class ContactModel
    {
        [DisplayName("Förnamn")]
        public string FirstName { get; set; } = null!;

        [DisplayName("Efternamn")]
        public string LastName { get; set; } = null!;

        [DisplayName("E-postadress")]
        public string Email { get; set; } = null!;
        public AddressModel? Address { get; set; } = new();
    }
}
