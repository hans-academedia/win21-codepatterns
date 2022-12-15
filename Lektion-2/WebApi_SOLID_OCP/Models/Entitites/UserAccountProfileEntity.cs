namespace WebApi_SOLID_OCP.Models.Entitites
{
    public class UserAccountProfileEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? StreetName { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? PhoneNumber { get; set; }
        public Guid UserId { get; set; }
        public UserAccountEntity? UserAccount { get; set; }
    }
}