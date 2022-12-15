using WebApi_SOLID_OCP.Contexts;
using WebApi_SOLID_OCP.Handlers.Authentication;

namespace WebApi_SOLID_OCP.Models.Account
{
    public class ProgramManagerAccountModel : IAccountModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? PostalCode { get; set; }
        public string? StreetName { get; set; }
        public string? City { get; set; }
        public int RoleId { get; set; } = 2;

        public IAuthenticationHandler AuthenticationHandler { get; set; } = new ProgramManagerAccountAuthenticationHandler();
    }
}
