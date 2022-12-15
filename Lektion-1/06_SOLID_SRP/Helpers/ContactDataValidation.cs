using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_SOLID_SRP.Helpers
{
    internal static class ContactDataValidation
    {
        public static bool ValidateText(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return true;
        }

        public static bool ValidateEmail(string input)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.Match(input).Success;
        }
    }
}
