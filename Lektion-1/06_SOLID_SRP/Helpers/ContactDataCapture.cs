using _06_SOLID_SRP.Models;

namespace _06_SOLID_SRP.Helpers
{
    internal static class ContactDataCapture
    {
        public static ContactModel Capture()
        {
            var contact = new ContactModel();

            contact.FirstName = CaptureData("Ange ett förnamn:");
            while(!ContactDataValidation.ValidateText(contact.FirstName))
            {
                ContactMessage.RequiredMessage("Du måste ange ett giltigt förnamn.");
                contact.FirstName = CaptureData("Ange ett förnamn:");
            }

            contact.LastName = CaptureData("Ange ett efternamn:");
            ContactDataValidation.ValidateText(contact.LastName);

            contact.Email = CaptureData("Ange en e-postadress:");
            ContactDataValidation.ValidateEmail(contact.Email);

            contact.Address.StreetName = CaptureData("Ange ett gatunamn:");
            contact.Address.PostalCode = CaptureData("Ange ett postnummer:");
            contact.Address.City = CaptureData("Ange en stad:");

            return contact;
        }

        public static string CaptureData(string text)
        {
            Console.Write($"{text} ");
            return Console.ReadLine() ?? "";
        }
    }
}