using _01_DRY.Models;

namespace _01_DRY.Factories;

internal static class ConsultantFactory
{
    public static Consultant CreateConsultant(string firstName, string lastName, string email, string phoneNumber)
    {
        return new Consultant()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            PhoneNumber = phoneNumber
        };


    }
}
