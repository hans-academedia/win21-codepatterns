using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SOLID_SRP.Helpers
{
    internal static class SystemMessage
    {
        public static void ClearMessages()
        {
            Console.Clear();
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Välkommen till adressboken.");
        }

        public static void EndApplicationMessage()
        {
            Console.WriteLine("Tryck på valfri knapp för att avsluta programmet");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
