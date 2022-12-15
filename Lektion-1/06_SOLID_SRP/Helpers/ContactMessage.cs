using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SOLID_SRP.Helpers
{
    internal static class ContactMessage
    {

        public static void RequiredMessage(string input)
        {
            Console.WriteLine($"{input}");
            Console.ReadKey();
        }

        public static bool RepeatProcessMessage()
        {
            Console.Write("Vill du lägga till en ny kontaktperson? (Y/N): ");
            return ((Console.ReadLine().ToLower() ?? "") == "y") ? true : false;
        }

    }
}
