using _01_DRY.Interfaces.Models.BaseModels;

namespace _01_DRY.Models.BaseModels;

internal abstract class BasePerson : IBasePerson
{
    public string DisplayName => $"{FirstName} {LastName}";

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    
    private string email = null!;
    public string Email
    {
        get { return email; }
        set { email = value.Trim().ToLower(); }
    }


    private string phoneNumber = null!;
    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = $"+46{value.Trim().Replace("-","").Replace(" ","").TrimStart('0')}"; }
    }

}
