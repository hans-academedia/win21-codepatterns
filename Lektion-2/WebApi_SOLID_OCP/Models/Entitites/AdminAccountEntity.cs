using System.Security.Cryptography;
using System.Text;

namespace WebApi_SOLID_OCP.Models.Entitites
{
    public class AdminAccountEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public byte[] Password { get; private set; } = null!;
        public byte[] Salt { get; private set; } = null!;

        public int RoleId { get; set; }
        public AdminAccountRoleEntity? Role { get; set; }


        public void GeneratePassword(string password)
        {
            using var hmac = new HMACSHA512();
            Salt = hmac.Key;
            Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
