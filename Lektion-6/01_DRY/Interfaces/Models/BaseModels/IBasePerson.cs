namespace _01_DRY.Interfaces.Models.BaseModels;

internal interface IBasePerson : IContactInformation
{
    string DisplayName { get; }
    string FirstName { get; set; }
    string LastName { get; set; }
}