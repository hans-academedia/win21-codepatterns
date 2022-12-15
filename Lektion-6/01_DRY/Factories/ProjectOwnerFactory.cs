using _01_DRY.Models;

namespace _01_DRY.Factories;

internal static class ProjectOwnerFactory
{
    public static ProjectOwner CreateProjectOwner(string firstName, string lastName, string email, string phoneNumber)
    {
        return new ProjectOwner()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            PhoneNumber = phoneNumber
        };

    }
}
