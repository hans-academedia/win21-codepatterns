namespace WebApi_SOLID_OCP.Models.Authentication
{
    public class SignUpModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? StreetName { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string Password { get; set; } = null!;
        public int AccountTypeId { get; set; } = 0;
    }
}
