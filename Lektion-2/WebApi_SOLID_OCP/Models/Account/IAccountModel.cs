using WebApi_SOLID_OCP.Handlers.Authentication;

namespace WebApi_SOLID_OCP.Models.Account
{
    public interface IAccountModel: IAddressModel
    {
        Guid Id { get; set; }
        string FirstName { get; set; }
        string Email { get; set; }
        string LastName { get; set; }
        string? PhoneNumber { get; set; }
        public int RoleId { get; set; }

        public IAuthenticationHandler AuthenticationHandler { get; set; }

    }
}