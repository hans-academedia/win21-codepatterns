using WebApi_SOLID_OCP.Models.Account;
using WebApi_SOLID_OCP.Models.Authentication;

namespace WebApi_SOLID_OCP.Handlers.Mapping
{
    /// <summary>
    /// 
    /// </summary>

    public static class MappingHandler
    {
        public static void Map(IAccountModel destination, SignUpModel source)
        {
            destination.FirstName = source!.FirstName;
            destination.LastName = source!.LastName;
            destination.Email = source!.Email;
            destination.StreetName = source?.StreetName;
            destination.PostalCode = source?.PostalCode;
            destination.City = source?.City;
            destination.PhoneNumber = source?.PhoneNumber;
        }
    }
}
