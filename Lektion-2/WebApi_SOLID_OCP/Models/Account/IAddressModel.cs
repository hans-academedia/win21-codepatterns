namespace WebApi_SOLID_OCP.Models.Account
{
    public interface IAddressModel
    {
        string? PostalCode { get; set; }
        string? StreetName { get; set; }
        string? City { get; set; }
    }
}
