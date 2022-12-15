using System.Security.Cryptography;
using System.Text;

namespace WebApi_SOLID_OCP.Models.Entitites
{
    public class UserAccountEntity
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public byte[] Password { get; private set; } = null!;
        public byte[] Salt { get; private set; } = null!;
        public UserAccountProfileEntity? UserProfile { get; set; }

        public void GeneratePassword(string password)
        {
            using var hmac = new HMACSHA512();
            Salt = hmac.Key;
            Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
     }
}
