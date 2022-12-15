using _06_SOLID_SRP.Helpers;
using _06_SOLID_SRP.Models;

namespace _06_SOLID_SRP;

class Program
{
    static void Main(string[] args)
    {
        var contactList = new List<ContactModel>();

        do
        {
            SystemMessage.ClearMessages();
            SystemMessage.WelcomeMessage();
            var contact = ContactDataCapture.Capture();

            contactList.Add(contact);
            ContactListHandleFile.SaveToJsonFile(contactList, $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\list.json");
        }

        while (ContactMessage.RepeatProcessMessage());
        SystemMessage.EndApplicationMessage();
    }
}